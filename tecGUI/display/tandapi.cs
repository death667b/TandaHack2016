using System;
using System.Collections.Specialized;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace tecGUI
{
    /// <summary>
    /// Creates a simple POST-based connection with the Tanda API
    /// </summary>
    public class TandaClient
    {
        #region Connection Data
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; private set; }

        /// <summary>
        /// The base URL for getting access tokens
        /// </summary>
        public const string API_Token_Endpoint = "https://my.tanda.co/api/oauth/token";

        /// <summary>
        /// The base URL for all interaction with the Tanda API.
        /// </summary>
        public const string API_Endpoint = "https://my.tanda.co/api/v2/";

        /// <summary>
        /// Get the current connection status of the client
        /// </summary>
        public bool IsConnected { get; private set; }
        #endregion

        #region Event Handlers
        public delegate void OnResponseHandler(object sender, ResponseEventArgs e);
        public event OnResponseHandler OnResponse;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialize this Tanda client with Username and Password
        /// </summary>
        /// <param name="username">Your sign-up email</param>
        /// <param name="password">Use 'tandahack2016' for Hackathon purposes</param>
        public TandaClient(string username, string password)
        {
            Username = username;
            Password = password;
            AccessToken = "";
            IsConnected = false;
        }
        #endregion

        #region Generate Access Tokens
        /// <summary>
        /// Gets a new valid access code to access the Tanda API
        /// </summary>
        /// <returns></returns>
        public string GetNewAccessToken()
        {
            var client = new RestClient(API_Token_Endpoint);
            var request = new RestRequest(Method.POST);
            request.AddParameter("username", Username);
            request.AddParameter("password", Password);
            request.AddParameter("scope", "me roster timesheet department role user cost leave unavailability datastream device");
            request.AddParameter("grant_type", "password");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            if (OnResponse != null)
                OnResponse(this, new ResponseEventArgs(content));
            JToken token = JObject.Parse(content);
            string access_code = (string)token.SelectToken("access_token");
            return access_code;
        }
        #endregion

        #region Add User
        public string AddUser(TandaUser user)
        {
            if (IsConnected)
            {
                string body = JsonConvert.SerializeObject(user);
                var client = new RestClient(API_Endpoint + "users");
                var request = new RestRequest(Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(user);
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + AccessToken);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                if (OnResponse != null)
                    OnResponse(this, new ResponseEventArgs(content));
                return content;
            }
            else
            {
                if (Connect(false))
                    return AddUser(user);
                else
                {
                    throw new Exception("Could not connect to Tanda.");
                }
            }
        }
        #endregion

        #region Get Simple User Information
        public string Get(string extension)
        {
            if (IsConnected)
            {
                var client = new RestClient(API_Endpoint + extension);
                var request = new RestRequest(Method.GET);
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Authorization", "Bearer " + AccessToken);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                if (OnResponse != null)
                    OnResponse(this, new ResponseEventArgs(content));
                return content;
            }
            else
            {
                if (Connect(false))
                    return Get(extension);
                else
                {
                    throw new Exception("Could not connect to Tanda.");
                }
            }
        }

        public string GetCurrentUserInformation()
        {
            string user_data = Get("users/me");
            return user_data;
        }
        #endregion

        #region General Connection
        /// <summary>
        /// Connects to the Tanda API service.
        /// </summary>
        /// <returns>True is successful, false if not</returns>
        public bool Connect(bool forceNewToken)
        {
            if (IsConnected)
                return true;
            try
            {
                AccessToken = GetNewAccessToken();
                IsConnected = true;
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }

    /// <summary>
    /// Used to open access to raw API data from the API client's communication with Tanda
    /// </summary>
    public class ResponseEventArgs : EventArgs
    {
        public string Response { get; private set; }
        public ResponseEventArgs()
        {
            Response = "";
        }
        public ResponseEventArgs(string response)
        {
            Response = response;
        }
    }

    /// <summary>
    /// Class for directly interfacing with the Tanda User definition
    /// </summary>
    public class TandaUser
    {
        public string name { get; set; }
        public string passcode { get; set; }
        public string phone { get; set; }
        public string date_of_birth { get; set; }
        public string employment_start_date { get; set; }
        public string email { get; set; }
        //public string password { get; set; }
        //public int report_department_id { get; set; }
        //public int[] role_ids { get; set; }
        //public int preferred_hours { get; set; }
        //public int[] award_ids { get; set; }
        //public int[] department_ids { get; set; }
        //public int[] managed_department_ids { get; set; }
        //public string[] user_levels { get; set; }
        //public int yearly_salary { get; set; }
    }

    /// <summary>
    /// Used to effectively handle User Data
    /// </summary>
    public class User
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string TaxFileNumber { get; set; }
        public string TaxFreeThreshold { get; set; }
        public string PhoneNumber { get; set; }
        public string BSB { get; set; }
        public string AccountNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string StartDate { get; set; }
        public string Type { get; set; }
        public string JobType { get; set; }
        public string ToBePrinted { get; set; }
        public string Qualification1 { get; set; }
        public string Qualification2 { get; set; }
        public string Qualification3 { get; set; }

        /// <summary>
        /// Create a new User based on an array of data.
        /// </summary>
        /// <param name="data">A 24-children array containing all necessary data on this user.</param>
        public User(string[] data)
        {
            if (data.Length != 24)
                throw new Exception("Corruption: Array 'data' has the wrong number of children.");

            EmployeeID = data[0];
            FirstName = data[1];
            LastName = data[2];
            Email = data[3];
            Gender = data[4];
            DOB = data[5];
            TaxFileNumber = data[6];
            TaxFreeThreshold = data[7];
            PhoneNumber = data[8];
            BSB = data[9];
            AccountNumber = data[10];
            AddressLine1 = data[11];
            AddressLine2 = data[12];
            AddressLine3 = data[13];
            City = data[14];
            State = data[15];
            Postcode = data[16];
            StartDate = data[17];
            Type = data[18];
            JobType = data[19];
            ToBePrinted = data[20];
            Qualification1 = data[21];
            Qualification2 = data[22];
            Qualification3 = data[23];
        }

        public TandaUser ToTandaUser()
        {
            return new TandaUser()
            {
                name = FirstName + LastName,
                passcode = Postcode,
                phone = PhoneNumber,
                date_of_birth = DateTime.Parse(DOB).ToString("yyyy-MM-dd"),
                employment_start_date = DateTime.Parse(StartDate).ToString("yyyy-MM-dd"),
                email = Email
            };
        }
    }
}