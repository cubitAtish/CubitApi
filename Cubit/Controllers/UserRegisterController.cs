using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.BALInterface;
using BusinessLayer;
using ClassEntities;
using ExceptionUtility;
using DataAccessLayer;
using Newtonsoft.Json.Linq;
//using System.Web.Mvc;

namespace Cubit.Controllers
{
    public class UserRegisterController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        IUserInfoBAL objUserInfoBAL = new UserInfoBAL();
        IDataValidation objValidation = new DataValidations();
        string jsonResult = string.Empty;


        private static readonly log4net.ILog log =
           log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /*-----------------------------------------------------------------------LOGIN/AUTHENTICATION---------------------------------------------*/

        //[HttpGet] // addAuthToken 
        //public HttpResponseMessage addAuthToken(Authtoken autoken)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            objUserInfoBAL.addAuthToken(autoken);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding authenticating." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // login 
        //public void login(string email, string password)
        //{
        //    try
        //    {
        //        bool boolValue = objUserInfoBAL.login(email, password);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while authenticating" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }

        //}


        /*------------------------------------------------------------------------USER REGISTRATION-------------------------------------------------*/

        //[HttpGet] // getCountry 
        //public List<country> getCountry()
        //{
        //    List<country> objCountry = new List<country>();
        //    try
        //    {
        //        objCountry = objUserInfoBAL.getCountry();
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(objCountry);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting country list" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(ex.Message);
        //    }
        //    return objCountry;
        //}

        /*-----------------------------*/

        [HttpGet] // getState 
        public List<state> getState(int countryId)
        {

            List<state> objState = new List<state>();
            try
            {
                objState = objUserInfoBAL.getState(countryId);
                jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(objState);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting state list" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return objState;
        }

        /*-----------------------------*/

        //[HttpPost] // getCity 
        //public List<city> getCity(int stateId)
        //{
        //    List<city> objCity = new List<city>();
        //    try
        //    {
        //        objCity = objUserInfoBAL.getCity(stateId);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting city list" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return objCity;
        //}

        /*-----------------------------*/

        //[HttpPost] // addNewUser 
        //public HttpResponseMessage addNewUser(UserPersonalInfo userPerInfo)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            objUserInfoBAL.addNewUser(userPerInfo);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding UserInfo." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // addNewTeacher  
        //public HttpResponseMessage addNewTeacher(Teacher userPerInfo)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            objUserInfoBAL.addNewTeacher(userPerInfo);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding Teacher info." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // addNewParent  
        //public HttpResponseMessage addNewParent(Parent userPerInfo)
        //{
        //    try
        //    {
        //        //if (ModelState.IsValid)
        //        // {
        //        objUserInfoBAL.addNewParent(userPerInfo);
        //        // }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding Teacher info." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // addNewStudent  
        //public HttpResponseMessage addNewStudent(Student userPerInfo)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            objUserInfoBAL.addNewStudent(userPerInfo);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding Teacher info." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}
        /*-----------------------------*/

        //[HttpPost] // addNewInstitute [16/11/16]
        //public HttpResponseMessage addNewInstitute(Institution institution)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            objUserInfoBAL.addNewInstitute(institution);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding institution info." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*--------------------------------------------------------------------------CREATE GROUP---------------------------------------------------*/

        //[HttpPost] // createGroup 
        //public HttpResponseMessage createGroup(Group objGroup)
        //{
        //    try
        //    {
        //        objUserInfoBAL.createGroup(objGroup);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while creating new group." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // sendGroupRequest 
        //public HttpResponseMessage sendGroupRequest(RequestStatus requestStatus)
        //{
        //    try
        //    {
        //        objUserInfoBAL.sendGroupRequest(requestStatus);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while sending group request." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // addUserToGroup
        //public HttpResponseMessage addUserToGroup(UserGroup userGroup)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addUserToGroup(userGroup);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while adding user to the group." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // rejectGroupRequest 
        //public HttpResponseMessage rejectGroupRequest(UserGroup userGroup)
        //{
        //    try
        //    {
        //        objUserInfoBAL.rejectGroupRequest(userGroup);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while rejecting group request." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] //deleteGroup 
        //public HttpResponseMessage deleteGroup(Group objGroup)
        //{
        //    try
        //    {
        //        objUserInfoBAL.deleteGroup(objGroup);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while delete group." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // updateGroup 
        //public HttpResponseMessage updateGroup(ClassEntities.Group objGroup)
        //{
        //    try
        //    {
        //        //if (ModelState.IsValid)
        //        // {
        //        objUserInfoBAL.updateGroup(objGroup);
        //        // }
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while update group." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------*/

        //[HttpPost] // getUserGroupList 
        //public List<group> getUserGroupList(int userID)
        //{
        //    List<group> objGroup = new List<group>();
        //    try
        //    {
        //        objGroup = objUserInfoBAL.getUserGroupList(userID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting user group list" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return objGroup;
        //}

        /*-----------------------------*/

        //[HttpPost] // userMemberGroup 
        //public void userMemberGroup(UserGroup objGroup)
        //{
        //    try
        //    {
        //        objUserInfoBAL.userMemberGroup(objGroup);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting user group list" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //}

        /*----------------------------------------------------------------------------FORGOT PASSWORD---------------------------------------------*/

        //[HttpPost] // generateLink 
        //public HttpResponseMessage generateLink(UserPersonalInfo userPerInfo)
        //{
        //    try
        //    {
        //        objUserInfoBAL.generateLink(userPerInfo);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while generating Link for forgot password." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------------------------------------------------CHANGE PASSWORD----------------------------------------------*/

        //[HttpPost] // updatePassword 
        //public HttpResponseMessage updatePassword(UserInfo userInfo)
        //{
        //    try
        //    {
        //        objUserInfoBAL.updatePassword(userInfo);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while updateing Password." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------------------------------------------------------VALIDATIONS-------------------------------------------------*/


        //[HttpGet] // validateEmail 
        //public bool validateEmail(string inputEmail)
        //{
        //    bool boolValue = false;
        //    try
        //    {

        //         boolValue = objValidation.validateEmail(inputEmail);

        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while validating email" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }

        //    return boolValue;
        //}

        /*--------------------------------*/
        //[HttpGet] // validateDateOfBirth 
        //public bool validateDateOfBirth(DateTime dateOfBirth)
        //{
        //    bool boolValue = false;
        //    try
        //    {
        //         boolValue = objValidation.validateDateOfBirth(dateOfBirth);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while validating DateOfBirth" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return boolValue;
        //}

        /*---------------------------------*/

        //[HttpGet] // validateName 
        //public bool validateName(string inputName)
        //{
        //    bool boolValue = false;
        //    try
        //    {
        //        boolValue = objValidation.validateName(inputName);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while validating Name" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return boolValue;
        //}
        /*---------------------------------*/

        //[HttpGet] // validateName 
        //public bool getValidate(string inputString)
        //{
        //    bool boolValue = false;
        //    try
        //    {
        //         boolValue = objValidation.getValidate(inputString);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while validating strings" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return boolValue;
        //}
        /*---------------------------------*/

        //[HttpGet] // validatePhoneNo 
        //public bool validatePhoneNo(string inputPhoneNo)
        //{
        //    bool boolValue = false;
        //    try
        //    {
        //         boolValue = objValidation.validatePhoneNo(inputPhoneNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while validating Phone Number" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return boolValue;
        //}

        /*----------------------------------*/

        //[HttpGet] // validatePassword 
        //public bool validatePassword(string inputPassword)
        //{
        //    bool boolValue = false;
        //    try
        //    {
        //        boolValue = objValidation.validatePassword(inputPassword);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while validating Password" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }
        //    return boolValue;
        //}


        /*-----------------------------------------------------------------------------PROFILE PAGE-------------------------------------------------*/

        /* ----------FETCH PROFILE,FRIENDS,CLASSMEATS,SCHOOLMATES ----------*/

        //[HttpGet] // getStudentProfileDetails 
        //public void getStudentProfileDetails(int student_institution_id)
        //{

        //    try
        //    {
        //        objUserInfoBAL.getStudentProfileDetails(student_institution_id);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting Same School Class Friends List" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }

        //}

        /*----------------------------------*/

        //[HttpGet] // getSameSchoolClassFriendsList 
        //public void getSameSchoolClassFriendsList(int student_institution_id, int student_class)
        //{

        //    try
        //    {
        //        objUserInfoBAL.getSameSchoolClassFriendsList(student_institution_id, student_class);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting Same School Class Friends List" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //    }

        //}

        /*----------------------------------*/

        //[HttpGet] // getSameSchoolFriendsList 
        //public string getSameSchoolFriendsList(int user_id, int student_institution_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<UserPersonalInfo> lstStudents = objUserInfoBAL.getSameSchoolFriendsList(user_id,student_institution_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstStudents);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting user profile details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpGet] // getDiffSchoolFriendsList 
        //public string getDiffSchoolFriendsList(int user_id, int student_institution_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<UserPersonalInfo> lstStudents = objUserInfoBAL.getDiffSchoolFriendsList(user_id,student_institution_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstStudents);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting user profile details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /* ---------FETCH EVENTS,DOCUMENTS,LOCATION,FEEDS,POST--------------*/

        //[HttpPost] // createEvent 
        //public HttpResponseMessage createEvent(EventPost events)
        //{
        //    try
        //    {
        //        objUserInfoBAL.createEvent(events);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while creating an Event" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpPost] // uploadDocument 
        //public HttpResponseMessage uploadDocument(Document document)
        //{
        //    try
        //    {
        //        objUserInfoBAL.uploadDocument(document);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while uploading a document " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpPost] // addGPSLocation 
        //public HttpResponseMessage addGPSLocation(GPSLocation location)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addGPSLocation(location);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting GPS locatins details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpPost] // addPost 
        //public HttpResponseMessage addPost(Post post)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addPost(post);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting Post details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpGet] // getUserEvents 
        //public HttpResponseMessage getUserEvents(int user_type)
        //{
        //    try
        //    {
        //        objUserInfoBAL.getUserEvents(user_type);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting list of events  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpGet] // getSameInstStudEvents 
        //public string getSameInstStudEvents(int student_institution_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<EventPost> lstOfEvents = objUserInfoBAL.getSameInstStudEvents(student_institution_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfEvents);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching same institution students list of events" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpGet] // getSameInstTeacherEvents 
        //public string getSameInstTeacherEvents(int teacher_institution_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<EventPost> lstOfEvents = objUserInfoBAL.getSameInstTeacherEvents(teacher_institution_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfEvents);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching same institution students list of events" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpGet] // getSameClassFriePost 
        //public string getSameClassFriePost(int user_id, int student_class)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<Post> lstOfEvents = objUserInfoBAL.getSameClassFriePost(user_id, student_class);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfEvents);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpGet] // getSameInstFriePost
        //public string getSameInstFriePost(int user_id, int institution_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<Post> lstOfEvents = objUserInfoBAL.getSameInstFriePost(user_id, institution_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfEvents);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        [HttpGet] // getStudentAnnouncement
        public string getStudentAnnouncement(int student_user_id, int institution_user_id)
        {
            string jsonResult = string.Empty;
            try
            {
                IQueryable<Post> lstOfEvents = objUserInfoBAL.getStudentAnnouncement(student_user_id, institution_user_id);
                jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfEvents);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching student announcement from institution" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
            }
            return jsonResult;
        }

        /*-----------------------------------------------------------------------------HOME PAGE------------------------------------------------------*/

        //[HttpGet] // getTimeTable 
        //public string getTimeTable(int institution_id, int section_id, int class_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<TimeTable> lstOfTimeTable = objUserInfoBAL.getTimeTable(institution_id, section_id, class_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfTimeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpGet] // getTeacherTimeTable 
        //public string getTeacherTimeTable(int institution_id, string teacher_name)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<TimeTable> lstOfTimeTable = objUserInfoBAL.getTeacherTimeTable(institution_id, teacher_name);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfTimeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpPost] // updateTimeTable 
        //public HttpResponseMessage updateTimeTable(PeriodTimeTable periodTimeTable)
        //{
        //    try
        //    {
        //        objUserInfoBAL.updateTimeTable(periodTimeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting TimeTable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpPost] // addTimeTable 
        //public HttpResponseMessage addTimeTable(PeriodTimeTable periodTimeTable)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addTimeTable(periodTimeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting TimeTable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        /*----------------------------------------------------------------------------EXAM SCHEDULE-----------------------------------------------------*/

        //[HttpPost] // addExamSchedule
        //public HttpResponseMessage addExamSchedule(ExamSchedule examSchedule)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addExamSchedule(examSchedule);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting Exam Schedules " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpPost] // addReportCard
        //public HttpResponseMessage addReportCard(ReportCard reportCard)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addReportCard(reportCard);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting Exam Schedules " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpGet] // getStudentResult 
        //public string getStudentResult(int student_id, int institution_id, int class_id, int section_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<ReportCard> lstofStudentResult = objUserInfoBAL.getStudentResult(student_id,institution_id,class_id,section_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstofStudentResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        //[HttpGet] // getStudentPerformanceSameClass
        //public string getStudentPerformanceSameClass(int institution_id, int class_id, int section_id)
        //{
        //    string jsonResult = string.Empty;

        //    try
        //    {
        //        double average = objUserInfoBAL.getStudentPerformanceSameClass(institution_id, class_id, section_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(average);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while getting user profile details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*----------------------------------*/

        /*----------------------------------------------------------------------------MY SLATE-----------------------------------------------------*/

        /*------------------HOME WORK----------------*/

        //[HttpPost] // addHomeWork
        //public HttpResponseMessage addHomeWork(HomeWork homework)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addHomeWork(homework);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting HomeWork Announce " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*----------------------------------*/

        //[HttpPost] // upload HomeWork
        //public HttpResponseMessage addHomeWorkUpload(HomeWorkUpload homeworkUpload)
        //{
        //    try
        //    {
        //        objUserInfoBAL.addHomeWorkUpload(homeworkUpload);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while inserting homeworkUpload" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*-----------------------------------*/

        //[HttpGet] // getHomeworkSubmitedtoTeacher 
        //public string getHomeworkSubmitedtoTeacher(int teacher_id)
        //{
        //    string jsonResult = string.Empty;
        //    try
        //    {
        //        IQueryable<HomeWorkUpload> lstOfTimeTable = objUserInfoBAL.getHomeworkSubmitedtoTeacher(teacher_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfTimeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}

        /*-----------------------------------*/

        //[HttpPost] // updateHomeWork 
        //public HttpResponseMessage updateHomeWork(HomeWork objHomeWork)
        //{
        //    try
        //    {
        //        objUserInfoBAL.updateHomeWork(objHomeWork);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while Update TimeTable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //    }
        //    return response = Request.CreateResponse(HttpStatusCode.OK);
        //}

        /*------------------MY PROJECT----------------*/

        /*------------------QUIZ----------------*/

        /*------------------COURSE MATERIAL----------------*/

        /*----------------------------------------------------------------------------INSTITUTION-----------------------------------------------------*/

        /*----------------STUDENT DATABASE-----------------*/

        //[HttpPost] //  getStudentDatabase[17/11/16]
        //public string getStudentDatabase(int user_id)
        //{            
        //    try
        //    {
        //        IQueryable<Student> lstOfTimeTable = objUserInfoBAL.getStudentDatabase(user_id);
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstOfTimeTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        CubitExceptionUtility.CubitExceptionLog(ex.Message + "API: Error while fetching Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        //        jsonResult = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize("Error");
        //    }
        //    return jsonResult;
        //}


        //[HttpPost]
        //public string testmethod()
        //{
        //    return "test sucessfull";
        //}

    }
}
