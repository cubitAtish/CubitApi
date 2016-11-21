
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BusinessLayer.BALInterface;
using ClassEntities;
using DataAccessLayer;
using DataAccessLayer.DALInterface;
using ExceptionUtility;
using DataAccessLayer.Enum;
using System.IO;


namespace BusinessLayer
{

    public class UserInfoBAL : IUserInfoBAL
    {
        delegate string generateGuid();
        generateGuid objGuid = delegate ()
        {
            Guid guid = Guid.NewGuid();
            string strGuid = guid.ToString();
            return strGuid;
        };
        IUserInfoDAL objUserInfoDAL = new UserInfoDAL();
        static readonly string[] FileSizeSuffixes = { "bytes", "KB", "MB", "GB" };

        /*--------------------------------------------------------------------------LOGIN/AUTHENTICATION-----------------------------*/

        public void addAuthToken(Authtoken token)
        {
            try
            {
                //token_key
                //token_expiry
                token.crdate = DateTime.Now;
                objUserInfoDAL.saveAuthToken(token);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while passing authotication values in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public bool  login(string email, string password)
        {
            bool boolvalue=false,valiBool = false;
            try
            {
                DataValidations objDataValidations = new DataValidations();
                valiBool = objDataValidations.checkValidateEmail(email);
                if(valiBool==false)
                {
                    return false; // return http response number : email is not valid
                }
                if (valiBool != false)
                {
                    boolvalue = objUserInfoDAL.login(email, password);
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while validating email" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return boolvalue;
        }

        /*--------------------------------------------------------------------------USER REGISTRATION---------------------------------*/

        public List<country> getCountry()
        {
            List<country> objCountry = new List<country>();
            try
            {
                objCountry = objUserInfoDAL.getCountry();
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling list of country in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objCountry;
        }

        public List<state> getState(int countryId)
        {
            List<state> objState = new List<state>();
            try
            {
                objState = objUserInfoDAL.getState(countryId);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling list of state in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objState;
        }

        public List<city> getCity(int stateId)
        {
            List<city> objCity = new List<city>();
            try
            {
                objCity = objUserInfoDAL.getCity(stateId);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling List of cities in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objCity;
        }

        public string addNewTeacher(Teacher userPerInfo)
        {
            try
            {
                userPerInfo.user_crdate = DateTime.Now;
                userPerInfo.user_isactive = true;
                //userlocked
                //user_failedattempt
                //user_lockedtilldate
                //user_crby
                //user_upddate
                int userid = objUserInfoDAL.getUserId(userPerInfo.user_email);
                if (userid == 0)
                {
                    objUserInfoDAL.addNewUser(userPerInfo);
                    userid = objUserInfoDAL.getUserId(userPerInfo.user_email);
                    userPerInfo.user_id = userid;
                    objUserInfoDAL.saveUserPersonalInfo(userPerInfo);
                    objUserInfoDAL.saveTeacherInfo(userPerInfo);

                    return "Success";
                }
                else
                {
                    return "User Exists";
                }                    

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while passing teacher details in to the DAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "error";
            }
        }

        public string addNewParent(Parent userPerInfo)
        {
            try
            {
                userPerInfo.user_crdate = DateTime.Now;
                userPerInfo.user_isactive = true;
                //userlocked
                //user_failedattempt
                //user_lockedtilldate
                //user_crby
                //user_upddate
                int userid = objUserInfoDAL.getUserId(userPerInfo.user_email);
                if (userid == 0)
                {
                    objUserInfoDAL.addNewUser(userPerInfo);
                    userid = objUserInfoDAL.getUserId(userPerInfo.user_email);
                    userPerInfo.user_id = userid;
                    objUserInfoDAL.saveUserPersonalInfo(userPerInfo);
                    if (userPerInfo.list_childeren_id.Count() > 1)
                    {
                        userPerInfo.parent_childeren_ids = string.Join(",", userPerInfo.list_childeren_id);
                    }
                    objUserInfoDAL.saveParentInfo(userPerInfo);
                    return "Success";
                }
                else
                {
                    return "User Exists";
                }
                    
               

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while passing parent details in to the DAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Error";
            }
        }

        public string addNewStudent(Student userPerInfo)
        {
            try
            {
                userPerInfo.user_crdate = DateTime.Now;
                userPerInfo.user_isactive = true;
                //userlocked
                //user_failedattempt
                //user_lockedtilldate
                //user_crby
                //user_upddate
                int userid = objUserInfoDAL.getUserId(userPerInfo.user_email);
                if (userid == 0)
                {
                    objUserInfoDAL.addNewUser(userPerInfo);
                    userid = objUserInfoDAL.getUserId(userPerInfo.user_email);
                    userPerInfo.user_id = userid;
                    objUserInfoDAL.saveUserPersonalInfo(userPerInfo);

                    objUserInfoDAL.saveStudentInfo(userPerInfo);
                    return "Success";
                }
                else
                {
                    return "User Exists";
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while passing student details in to the DAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());

                return "Error";
            }
        }

        public string addNewInstitute(Institution institution)
        {
            try
            {
                institution.user_crdate = DateTime.Now;
                institution.user_isactive = true;
                //userlocked
                //user_failedattempt
                //user_lockedtilldate
                //user_crby
                //user_upddate
                int userid = objUserInfoDAL.getUserId(institution.user_email);
                if (userid == 0)
                {
                    objUserInfoDAL.addInstitution(institution);
                    userid = objUserInfoDAL.getUserId(institution.user_email);
                    institution.user_id = userid;
                    objUserInfoDAL.saveInstitutionInfo(institution);
                    return "Success";
                }
                else
                {
                    return "User Exists";
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while passing student details in to the DAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());

                return "Error";
            }
        }

        /*------------------------------------------------------------------------------CREATE GROUP------------------------------------*/

        public void createGroup(ClassEntities.Group objGroup)
        {
            try
            {
                objGroup.group_isactive = true;
                objUserInfoDAL.createGroup(objGroup);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling create new group in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void sendGroupRequest(RequestStatus requestStatus)
        {
            try
            {
                requestStatus.request_status = Convert.ToInt16(EnumRequestStatus.requsetStatus.pending);
                requestStatus.request_crdate = DateTime.Now;
                //requestStatus.request_upddate=  ?
                objUserInfoDAL.sendGroupRequest(requestStatus);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling group request in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void updateRequest(RequestStatus requestStatus, EnumRequestStatus.requsetStatus status)
        {
            try
            {
                objUserInfoDAL.updateRequest(requestStatus, status);

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling update request in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void updateGroup(ClassEntities.Group objGroup)
        {
            try
            {
                objUserInfoDAL.updateGroup(objGroup);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling update group in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addUserToGroup(UserGroup userGroup)
        {
            try
            {
                RequestStatus objrequeststatus = new RequestStatus();
                objrequeststatus.request_to = userGroup.touser_id;
                objrequeststatus.request_from = userGroup.fromuser_id;
                objrequeststatus.request_for_group = userGroup.group_id;
                updateRequest(objrequeststatus, EnumRequestStatus.requsetStatus.approved);

                objUserInfoDAL.addUserToGroup(userGroup);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while adding user to the group in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void rejectGroupRequest(UserGroup userGroup)
        {
            try
            {
                RequestStatus objrequeststatus = new RequestStatus();
                objrequeststatus.request_to = userGroup.touser_id;
                objrequeststatus.request_from = userGroup.fromuser_id;
                objrequeststatus.request_for_group = userGroup.group_id;
                updateRequest(objrequeststatus, EnumRequestStatus.requsetStatus.reject);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while calling reject group in to the UserInfoDAL" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void deleteGroup(ClassEntities.Group objGroup)
        {
            try
            {
                objUserInfoDAL.deleteGroup(objGroup);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while deleting group" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public List<group> getUserGroupList(int userID)
        {
            List<group> objGroup = new List<group>();
            try
            {
                objGroup = objUserInfoDAL.getUserGroupList(userID);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while getting user group list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objGroup;
        }

        public List<usergroup> getGroupMembers(UserGroup objUserInfo)
        {
            List<usergroup> objAdminGroup = new List<usergroup>();

            try
            {

                objUserInfoDAL.getGroupMembers(objUserInfo);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while getting user group list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objAdminGroup;
        }

        public void userMemberGroup(UserGroup objGroup)
        {
            try
            {
                objUserInfoDAL.userMemberGroup(objGroup);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while deleting group" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }
        /*----------------------------------------------------------------------------FORGOT PASSWORD---------------------------------------*/

        public void generateLink(UserPersonalInfo userPerInfo)
        {
            
            try
            {
                DataValidations objDataValidation = new DataValidations();
                bool boolValue = objDataValidation.validateEmail(userPerInfo.user_email);
                
                if (boolValue != false)
                {
                    userPerInfo.pwdchange_redate = DateTime.Now;
                    userPerInfo.pwdchange_guid = objGuid.Invoke();
                    objUserInfoDAL.saveLink(userPerInfo);
                    forgotPassword(userPerInfo);
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while running Guid" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void forgotPassword(UserPersonalInfo userPerInfo)
        {
            userinfo objUserDetails = getUserDetails(userPerInfo);
            Email objEmail = new Email();
            objEmail.sendMails(objUserDetails);
        }

        public userinfo getUserDetails(UserPersonalInfo userPerInfo)
        {
            userinfo objUserInfo = new userinfo();
            try
            {
                objUserInfo = objUserInfoDAL.getUserDetails(userPerInfo);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching user details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return objUserInfo;
        }

        /*-----------------------------------------------------------------------------CHANGE PASSWORD-----------------------------------------*/

        public void updatePassword(UserInfo userInfo)
        {
            try
            {
                DataValidations objDataValidation = new DataValidations();
                bool boolValue = objDataValidation.validatePassword(userInfo.pwdchange_newpwd);
                if (boolValue != false)
                {
                    userInfo.pwdchange_upddate = DateTime.Now;
                    objUserInfoDAL.updatePassword(userInfo);
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while updating password" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*------------------------------------------------------------------------------VALIDATIONS---------------------------------------------*/

        public bool getEmailValidate(string inputEmail)
        {
            bool boolvalue = false;
            try
            {
                boolvalue = objUserInfoDAL.getEmailValidate(inputEmail);


            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while validating email" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return boolvalue;
        }

        /*-------------------------------------------------------------------------------PROFILE PAGE--------------------------------------------*/

        /* ----------FETCH PROFILE,FRIENDS,CLASSMEATS,SCHOOLMATES ----------*/

        public void getSameSchoolClassFriendsList(int student_institution_id, int student_class)
        {
            try
            {
                objUserInfoDAL.getSameSchoolClassFriendsList(student_institution_id, student_class);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while getting Same School Class Friends List" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public IQueryable<UserPersonalInfo> getSameSchoolFriendsList(int user_id, int student_institution_id)
        {
            try
            {
                IQueryable<UserPersonalInfo> lstStudents = objUserInfoDAL.getSameSchoolFriendsList(user_id,student_institution_id);
                return lstStudents;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching same school friends list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public IQueryable<UserPersonalInfo> getDiffSchoolFriendsList(int user_id, int student_institution_id)
        {
            try
            {
                IQueryable<UserPersonalInfo> lstStudents=objUserInfoDAL.getDiffSchoolFriendsList(user_id,student_institution_id);
                return lstStudents;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching different school friends list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public Student getStudentProfileDetails(int student_institution_id)
        {
            Student objStudent = new Student();
            try
            {
                objStudent = objUserInfoDAL.getStudentProfileDetails(student_institution_id);
                return objStudent;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching user profile details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return objStudent = new Student();
            }
        }

        /* ---------FETCH EVENTS,DOCUMENTS,LOCATION,FEEDS,POST--------------*/
         
        public void createEvent(EventPost events)
        {
            try
            {
                if(events.event_document_id!= null)
                {
                    if (events.list_document_id.Count() > 1)
                        events.event_document_id = string.Join(",", events.list_document_id);                   
                }else if(events.event_gpslocation_id!=null)
                {
                    if (events.list_gpslocation_id.Count() > 1)
                        events.event_gpslocation_id = string.Join(",", events.list_gpslocation_id);
                }                
                objUserInfoDAL.createEvent(events);
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while creating a event" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void uploadDocument(Document document)
        {
            string test = "D:testfolder/sample.png";
            try
            {
                document.doc_uploaddate = DateTime.Now;
                document.doc_extension = Path.GetExtension(test);
                   
                objUserInfoDAL.uploadDocument(document);
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while storing a Document" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }
   
        static string calculateFileSize(Int64 value)
        {
            if (value <= 0)
            {
                return " Document is in less that 0 size ";
            }
            else if (value > 1073741824)
            {
                return "Document is over size " + value + " Limit up to 1GB";
            }
            int i = 0;
            decimal dValue = (decimal)value;
            while (Math.Round(dValue / 1024) >= 1)
            {
                dValue /= 1024;
                i++;
            }

            return string.Format("{0:n1} {1}", dValue, FileSizeSuffixes[i]);
        }

        public void addGPSLocation(GPSLocation location)
        {
            try
            {
                objUserInfoDAL.addGPSLocation(location);
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while storing GPS location details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addPost(Post post)
        {
            try
            {
                post.post_date = DateTime.Now;

                if(post.post_doc_id!=null)
                {
                    if (post.list_document_id.Count() > 1)                   
                        post.post_doc_id = string.Join(",", post.list_document_id);                    
                }else if(post.list_gpslocation_id!=null)
                {
                    if (post.list_gpslocation_id.Count() > 1)                   
                        post.post_gpslocation_id = string.Join(",", post.list_gpslocation_id);                   
                }else if(post.list_gpslocation_id!=null)
                {
                    if (post.list_tag_user_id.Count() > 1)                   
                        post.post_tag_user_id = string.Join(",", post.list_tag_user_id);                   
                }else if(post.post_event_id!=null)
                {
                    if (post.list_event_id != null)
                        post.post_event_id = string.Join(",", post.list_event_id);
                }                                            
                objUserInfoDAL.addPost(post);

            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while storing Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }    

        public List<eventpost> getUserEvents(int user_type)
        {
            List<eventpost> objEventPost = new List<eventpost>();
            try
            {
                objEventPost = objUserInfoDAL.getUserEvents(user_type);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while getting user group list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objEventPost;
        }

        public IQueryable<EventPost> getSameInstStudEvents(int student_institution_id)
        {
            try
            {
                IQueryable<EventPost> listOfEvents = objUserInfoDAL.getSameInstStudEvents(student_institution_id);
                return listOfEvents;
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching same institution students list of events " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public IQueryable<EventPost> getSameInstTeacherEvents(int teacher_institution_id)
        {
            try
            {
                IQueryable<EventPost> listOfEvents = objUserInfoDAL.getSameInstTeacherEvents(teacher_institution_id);
                return listOfEvents;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching same institution teachers list of events " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public IQueryable<Post> getSameClassFriePost(int user_id, int student_class)
        {
            try
            {
                IQueryable<Post> listOfPost = objUserInfoDAL.getSameClassFriePost( user_id, student_class);
                return listOfPost;
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public IQueryable<Post> getSameInstFriePost(int user_id, int institution_id)
        {
            try
            {
                IQueryable<Post> listOfPost = objUserInfoDAL.getSameInstFriePost(user_id, institution_id);
                return listOfPost;
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public IQueryable<Post> getStudentAnnouncement(int student_user_id, int institution_user_id)
        {
            try
            {
                IQueryable<Post> listOfAnnouncement = objUserInfoDAL.getStudentAnnouncement(student_user_id, institution_user_id);
                return listOfAnnouncement;
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching institution announcements to student details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        /*-------------------------------------------------------------------------------HOME PAGE------------------------------------------------------*/

        public string addTimeTable(PeriodTimeTable periodTimeTable)
        {
            try
            {
                periodTimeTable.createddate = DateTime.Now;
                periodTimeTable.isactive = true;
                int TimeTableid = objUserInfoDAL.getTimeTableid(periodTimeTable.class_id, periodTimeTable.section_id);
                if (TimeTableid == 0)
                {
                    objUserInfoDAL.addTimeTable(periodTimeTable);
                    TimeTableid = objUserInfoDAL.getTimeTableid(periodTimeTable.class_id, periodTimeTable.section_id);
                    periodTimeTable.timetable_id = TimeTableid;
                    objUserInfoDAL.addPeriodTimeTable(periodTimeTable);
                    return "Success";
                }
                else
                {
                    return "User Exists";
                }


            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while inserting TimeTable details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Error";
            }

        }

        public IQueryable<TimeTable> getTimeTable(int institution_id, int section_id, int class_id)
        {
            try
            {
                IQueryable<TimeTable> lstOfTimeTable = objUserInfoDAL.getTimeTable(institution_id, section_id, class_id);
                return lstOfTimeTable;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching calender details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public IQueryable<TimeTable> getTeacherTimeTable(int institution_id, string teacher_name)
        {
            try
            {
                IQueryable<TimeTable> lstOfTimeTable = objUserInfoDAL.getTeacherTimeTable(institution_id, teacher_name);
                return lstOfTimeTable;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching calender details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public void updateTimeTable(PeriodTimeTable periodTimeTable)
        {
            try
            {
                if (periodTimeTable.institution_id == periodTimeTable.institution_id && periodTimeTable.createdby == periodTimeTable.createdby)
                {
                    objUserInfoDAL.updateTimeTable(periodTimeTable);
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while updating TimeTable" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*----------------------------------------------------------------------------EXAM SCHEDULE-----------------------------------------------------*/

        public string addExamSchedule(ExamSchedule examSchedule)
        {
            int id;
            try
            {
                id = objUserInfoDAL.getExamReportMappingid(examSchedule.erm_institution_id, examSchedule.erm_class_id, examSchedule.erm_section_id, examSchedule.exam_term);
                if (id == 0)
                {
                    objUserInfoDAL.addExamReportMapping(examSchedule);
                    id = objUserInfoDAL.getExamReportMappingid(examSchedule.erm_institution_id, examSchedule.erm_class_id, examSchedule.erm_section_id, examSchedule.exam_term);
                    examSchedule.erm_id = id;
                    objUserInfoDAL.addExamSchedule(examSchedule);
                    return "Success";
                }
                else
                {
                    return "User Exists";
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while storing Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Error";
            }
        }

        public string addReportCard(ReportCard reportCard)
        {
            int id;
            try
            {
                id = objUserInfoDAL.getExamReportMappingid(reportCard.erm_institution_id, reportCard.erm_class_id, reportCard.erm_section_id, reportCard.exam_term);
                if (id == 0)
                {
                    return "Alraedy this student created a report card ";
                }
                else
                {

                    id = objUserInfoDAL.getExamReportMappingid(reportCard.erm_institution_id, reportCard.erm_class_id, reportCard.erm_section_id, reportCard.exam_term);
                    reportCard.erm_id = id;
                    objUserInfoDAL.addReportCard(reportCard);
                    return "Success";

                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while storing Post details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Error";
            }
        }

        public IQueryable<ReportCard> getStudentResult(int student_id, int institution_id, int class_id, int section_id)
        {
            try
            {
                IQueryable<ReportCard> lstofStudentResult = objUserInfoDAL.getStudentResult(student_id, institution_id, class_id, section_id);
                return lstofStudentResult;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching calender details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public double getStudentPerformanceSameClass(int institution_id, int class_id, int section_id)
        {
            double average = 0;
            try
            {
                average = objUserInfoDAL.getStudentPerformanceSameClass(institution_id, class_id, section_id);

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while get Student Performance Same Class" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return average;
        }

        /*----------------------------------------------------------------------------MY SLATE-----------------------------------------------------*/

        /*------------------HOME WORK----------------*/
        public string addHomeWork(HomeWork homework)
        {
            try
            {

                homework.isactive = true;
                objUserInfoDAL.addHomeWork(homework);
                return "Success";
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while Homework Announce" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Error";
            }

        }

        public string addHomeWorkUpload(HomeWorkUpload homeworkUpload)
        {

            try
            {
                int homeworkid = objUserInfoDAL.getHomeWorkId(homeworkUpload.hw_teacher_id, homeworkUpload.hw_subject_id);
                homeworkUpload.homework_id = homeworkid;
                homeworkUpload.isactive = true;
                objUserInfoDAL.addHomeWorkUpload(homeworkUpload);
                return "Success";
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while add HomeWork Upload" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Error";
            }

        }

        public IQueryable<HomeWorkUpload> getHomeworkSubmitedtoTeacher(int teacher_id)
        {
            try
            {
                IQueryable<HomeWorkUpload> listOfHomeWorkSubited = objUserInfoDAL.getHomeworkSubmitedtoTeacher(teacher_id);
                return listOfHomeWorkSubited;
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

        public string updateHomeWork(HomeWork objHomeWork)
        {
            try
            {
                objUserInfoDAL.updateHomeWork(objHomeWork);
                return "Success UpDate Home Work Announce";
            }

            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while update HomeWork Announce" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return "Fail UpDate Home Work Announce";
            }
        }
        /*------------------MY PROJECT----------------*/

        /*--------------------QUIZ--------------------*/

        /*---------------COURSE MATERIAL--------------*/

        /*----------------------------------------------------------------------------INSTITUTION-----------------------------------------------------*/

        /*----------------STUDENT DATABASE-----------------*/

        public IQueryable<Student> getStudentDatabase(int user_id)
        {
            try
            {
                IQueryable<Student> listOfStudentDatabase = objUserInfoDAL.getStudentDatabase(user_id);
                return listOfStudentDatabase;
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while fetching student database details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                throw ex;
            }
        }

    }

}
