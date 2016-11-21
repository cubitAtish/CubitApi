
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEntities;
using DataAccessLayer.DALInterface;
using ExceptionUtility;
using DataAccessLayer.Enum;

namespace DataAccessLayer
{
     public class UserInfoDAL: IUserInfoDAL
    {
        cubitEntities objcubitEntities = new cubitEntities();
        
        /*------------------------------------------------------------------LOGIN/AUTHENTICATION-------------------------------------------------------*/

        public void saveAuthToken(Authtoken token)
        {
            try
            {
                //using (cubitEntities objcubitEntities = new cubitEntities())
                {
                    //  authtoken objauthotoken = new authtoken
                    //  {

                    //  };
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching authentication details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public bool login(string email, string password)
        {
            bool boolvalue = false;
            try
            {
                boolvalue = objcubitEntities.userinfoes.Any((x) => x.user_email == email && x.user_password == password);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while checking email id" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }


            return boolvalue;
        }
        /*--------------------------------------------------------------------USER REGISTRATION--------------------------------------------------------*/

        public List<country> getCountry()
        {
            List<country> objCountry = new List<country>();
            try
            {

                using (objcubitEntities)
                {
                    objCountry = objcubitEntities.countries.ToList<country>();

                }

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching country names " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objCountry;
        }

        public List<state> getState(int countryId)
        {
            List<state> objState = new List<state>();
            try
            {
                using (objcubitEntities)
                {
                    objState = objcubitEntities.states.Where((s) => s.state_countryid == countryId).ToList();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching state names" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objState;
        }

        public List<city> getCity(int stateId)
        {
            List<city> objcity = new List<city>();
            try
            {
                using (objcubitEntities)
                {
                    objcity = objcubitEntities.cities.Where((c) => c.city_stateid == stateId).ToList();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching city names" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objcity;
        }

        public void addNewUser(UserPersonalInfo userPerInfo)
        {
            try
            {
                using (objcubitEntities)
                {

                    userinfo objuserinfo = new userinfo
                    {
                        user_name = userPerInfo.user_name,
                        user_email = userPerInfo.user_email,
                        user_password = userPerInfo.user_password,
                        user_type = userPerInfo.user_type,
                        user_crdate = userPerInfo.user_crdate,
                        user_alternatemail = userPerInfo.user_alternatemail,

                    };
                    objcubitEntities.userinfoes.Add(objuserinfo);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving userinfo details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

        }

        public void addInstitution(Institution institution)
        {
            try
            {
                using (objcubitEntities)
                {

                    userinfo objuserinfo = new userinfo
                    {
                        user_name = institution.user_name,
                        user_email = institution.user_email,
                        user_password = institution.user_password,
                        user_type = institution.user_type,
                        user_crdate = institution.user_crdate,
                        user_alternatemail = institution.user_alternatemail,
                    };
                    objcubitEntities.userinfoes.Add(objuserinfo);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving institution userinfo details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

        }

        public int getUserId(string email)
        {
            int userid = 0;
            try
            {
                
                userid = objcubitEntities.userinfoes.Where((s) => s.user_email == email).Select((s) => s.user_id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while getting user id" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return userid;
        }

        public void saveUserPersonalInfo(UserPersonalInfo userPerInfo)
        {
            try
            {
                using (objcubitEntities)
                {
                    userpersonalinfo objuserpersonalinfo = new userpersonalinfo
                    {
                        user_id = userPerInfo.user_id,
                        userper_dob = userPerInfo.userper_dob,
                        userper_gender = userPerInfo.userper_gender,
                        userper_countryid = userPerInfo.userper_countryid,
                        userper_stateid = userPerInfo.userper_stateid,
                        userper_cityid = userPerInfo.userper_cityid,
                        userper_favoiritesubjects = userPerInfo.userper_favoiritesubjects,
                        userper_sports = userPerInfo.userper_sports,
                        userper_hobbies = userPerInfo.userper_hobbies,
                        userper_personalities = userPerInfo.userper_personalities,
                        userper_books = userPerInfo.userper_books,
                        userper_movies = userPerInfo.userper_movies,
                        userper_mobile = userPerInfo.userper_mobile,
                        userper_alternatemobile=userPerInfo.userper_alternatemobile,
                        userper_profile_pic = userPerInfo.userper_profile_pic,

                    };
                    objcubitEntities.userpersonalinfoes.Add(objuserpersonalinfo);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving userpersonalinfo details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void saveStudentInfo(Student student)
        {
            try
            {
                using (objcubitEntities)
                {
                    student objStudent=new student
                    {
                        user_id= student.user_id,
                        student_regid=student.student_regid,
                        student_roll_no=student.student_roll_no,
                        student_section=student.student_section,
                        student_class=student.student_class,
                        student_institution_id=student.student_institution_id,
                        student_cca=student.student_cca,
                        student_eca=student.student_eca,

                    };
                    objcubitEntities.students.Add(objStudent);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving studentinfo details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void saveTeacherInfo(Teacher teacher)
        {
            try
            {
                using (objcubitEntities)
                {
                    teacher objTeacher = new teacher
                    {
                        user_id=teacher.user_id,
                        teacher_code=teacher.teacher_code,

                    };
                    objcubitEntities.teachers.Add(objTeacher);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving teacher details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void saveParentInfo(Parent parent)
        {
            try
            {
                using (objcubitEntities)
                {
                    parent objparent = new parent
                    {
                        user_id = parent.user_id,
                        parent_childeren = parent.parent_childeren_ids,
                        parent_occupation = parent.parent_occupation,
                        parent_nameofspouse = parent.parent_nameofspouse,
                    };
                    objcubitEntities.parents.Add(objparent);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving teacher details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void saveInstitutionInfo(Institution objInstitut)
        {
            try
            {
                using (objcubitEntities)
                {
                    institution objinstitution = new institution
                    {
                        user_id = objInstitut.user_id,
                        institution_country= objInstitut.institution_country,
                        institution_state= objInstitut.institution_state,
                        institution_city= objInstitut.institution_city,
                        institution_name= objInstitut.institution_name,
                        institution_address= objInstitut.institution_address,
                        institution_website= objInstitut.institution_website,
                        institution_poc= objInstitut.institution_poc,
                        institution_nostudents= objInstitut.institution_nostudents,
                        institution_class_id= objInstitut.institution_class_id,
                    };
                }
            }catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving institution details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*---------------------------------------------------------------------CREATE GROUP------------------------------------------------------------*/

        public void createGroup(Group objGroup)
        {
            try
            {
                using (objcubitEntities)
                {
                    group objgroupcr = new group
                    {
                        group_name = objGroup.group_name,
                        group_isactive = objGroup.group_isactive,
                        group_description = objGroup.group_description,
                        group_privacy = objGroup.group_privacy,
                        user_id = objGroup.user_id,
                    };
                    objcubitEntities.groups.Add(objgroupcr);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "Error while saving new group details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

        }

        public void sendGroupRequest(RequestStatus requestStatus)
        {

            try
            {
                using (objcubitEntities)
                {
                    requeststatu objrequsetstatus = new requeststatu
                    {
                        request_from = requestStatus.request_from,
                        request_to = requestStatus.request_to,
                        request_status = requestStatus.request_status,
                        request_for_group = requestStatus.request_for_group,
                        request_note = requestStatus.request_note,
                        request_crdate = requestStatus.request_crdate,
                        request_upddate = requestStatus.request_upddate,
                    };

                    objcubitEntities.requeststatus.Add(objrequsetstatus);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "Error while saving group request details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

        }

        public void updateRequest(RequestStatus requestStatus, EnumRequestStatus.requsetStatus status)
        {

            try
            {
                using (objcubitEntities)
                {
                    var updaterequest_status = objcubitEntities.requeststatus.Where((u) => u.request_for_group == requestStatus.request_for_group && u.request_from == requestStatus.request_from && u.request_to == requestStatus.request_to).FirstOrDefault();
                    if (updaterequest_status != null)
                    {
                        updaterequest_status.request_status = Convert.ToInt16(status);
                    }
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "Error while updating request status" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }


        }

        public void addUserToGroup(UserGroup userGroup)
        {

            try
            {
                using (objcubitEntities)
                {
                    usergroup objusergroup = new usergroup
                    {
                        group_id = userGroup.group_id,
                        fromuser_id = userGroup.fromuser_id,
                        touser_id = userGroup.touser_id,
                    };
                    objcubitEntities.usergroups.Add(objusergroup);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "Error while saving user details in to the group" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

        }

        public void deleteGroup(Group objGroup)
        {
            group groupdelete;
            using (var ctx = new cubitEntities())
            {
                groupdelete = ctx.groups.Where((u) => u.user_id == objGroup.user_id).FirstOrDefault();
            }
            using (var newcon = new cubitEntities())
            {
                newcon.Entry(groupdelete).State = System.Data.EntityState.Deleted;
                newcon.SaveChanges();
            }
            

        }

        public void updateGroup(Group objGroup)
        {
            try
            {
                using (objcubitEntities)

                {
                    group objgroup = objcubitEntities.groups.Single(g => g.group_id == objGroup.group_id && g.user_id == objGroup.user_id);
                    objgroup.group_name = objGroup.group_name;
                    objgroup.group_isactive = objGroup.group_isactive;
                    objgroup.group_description = objGroup.group_description;
                    objgroup.group_privacy = objGroup.group_privacy;
                    objcubitEntities.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while Updating Group." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public List<group> getUserGroupList(int userID)
        {
            List<group> objGroup = new List<group>();
            try
            {
                using (objcubitEntities)
                {
                    objGroup = objcubitEntities.groups.Where((u) => u.user_id == userID).ToList();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching list of user Groups list." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objGroup;
        }

        public List<usergroup> getGroupMembers(UserGroup objUserGroup)
        {
            List<usergroup> objAdminGroup = new List<usergroup>();
            try
            {
                using (objcubitEntities)
                {
                    objAdminGroup = objcubitEntities.usergroups.Where((u) => u.group_id == objUserGroup.group_id).ToList();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching list of admin Groups list." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objAdminGroup;
        }

        public void userMemberGroup(UserGroup objGroup)
        {
            try
            {
                using (objcubitEntities)
                {
                    var q = (from ui in objcubitEntities.userinfoes
                             join ug in objcubitEntities.usergroups on ui.user_id equals ug.touser_id
                             where ug.group_id == objGroup.group_id
                             select new
                             {
                                 ug.touser_id,
                                 ui.user_name,
                             }).ToList();

                    objcubitEntities.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL : Error userMemberGroup fetaching data." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*----------------------------------------------------------------------FORGOT PASSWORD------------------------------------------------------*/

        public void saveLink(UserPersonalInfo userPerInfo)
        {
            try
            {
                using (objcubitEntities)
                {
                    var addLink = objcubitEntities.userinfoes.Where((l) => l.user_email == userPerInfo.user_email).FirstOrDefault();
                    {
                        addLink.pwdchange_redate = userPerInfo.pwdchange_redate;
                        addLink.pwdchange_guid = userPerInfo.pwdchange_guid;
                    }
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving password change details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public userinfo getUserDetails(UserPersonalInfo userPerInfo)
        {

            userinfo objUserInfo = new userinfo();
            try
            {
                //cubitEntities objcubitEntities = new cubitEntities();

                objUserInfo = objcubitEntities.userinfoes.Where((s) => s.user_id == userPerInfo.user_id || s.user_email == userPerInfo.user_email).FirstOrDefault();
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching user details" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return objUserInfo;
        }

        /*----------------------------------------------------------------------CHANGE PASSWORD------------------------------------------------------*/

        public void updatePassword(UserInfo userInfo)
        {
            try
            {
                using (cubitEntities objcubitEntities = new cubitEntities())
                {
                    var updatePassword = objcubitEntities.userinfoes.Where((p) => p.pwdchange_guid == userInfo.pwdchange_guid).FirstOrDefault();
                    if (updatePassword != null)
                    {
                        updatePassword.pwdchange_oldpwd = updatePassword.user_password;
                        updatePassword.pwdchange_newpwd = userInfo.pwdchange_newpwd;
                        updatePassword.user_password = userInfo.pwdchange_newpwd;
                        updatePassword.pwdchange_upddate = userInfo.pwdchange_upddate;
                    }
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while updating Password" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*-----------------------------------------------------------------------VALIDATIONS---------------------------------------------------------*/

        public bool getEmailValidate(string inputEmail)
        {
            bool boolvalue = false;
            try
            {
                //cubitEntities objcubitEntities = new cubitEntities();

                boolvalue = objcubitEntities.userinfoes.Any((x) => x.user_email == inputEmail);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while checking email id" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }


            return boolvalue;
        }

        /*-----------------------------------------------------------------------PROFILE PAGE-------------------------------------------------------*/

        /* ----------FETCH PROFILE,FRIENDS,CLASSMEATS,SCHOOLMATES ----------*/

        public Student getStudentProfileDetails(int student_institution_id)
        {
            Student studentProfile = new Student();
            try
            {
                studentProfile = (from Stud in objcubitEntities.students
                                  join User in objcubitEntities.userinfoes on Stud.user_id equals User.user_id
                                  join UserPer in objcubitEntities.userpersonalinfoes on User.user_id equals UserPer.user_id
                                  where Stud.student_institution_id == student_institution_id
                                  select new Student
                                  {
                                      user_id = User.user_id,
                                      user_name = User.user_name,
                                      user_email = User.user_email,
                                      user_isactive = User.user_isactive,
                                      user_type = User.user_type,
                                      user_alternatemail = User.user_alternatemail,
                                      userper_dob = UserPer.userper_dob,
                                      userper_gender = UserPer.userper_gender,
                                      userper_countryid = UserPer.userper_countryid,
                                      userper_stateid = UserPer.userper_stateid,
                                      userper_cityid = UserPer.userper_cityid,
                                      userper_favoiritesubjects = UserPer.userper_favoiritesubjects,
                                      userper_hobbies = UserPer.userper_hobbies,
                                      userper_sports = UserPer.userper_sports,
                                      userper_personalities = UserPer.userper_personalities,
                                      userper_books = UserPer.userper_books,
                                      userper_movies = UserPer.userper_movies,
                                      userper_mobile = UserPer.userper_mobile,
                                      userper_alternatemobile = UserPer.userper_alternatemobile,
                                      userper_profile_pic = UserPer.userper_profile_pic,
                                      student_regid = Stud.student_regid,
                                      student_roll_no = Stud.student_roll_no,
                                      student_section = Stud.student_section,
                                      student_class = Stud.student_class,
                                      student_cca = Stud.student_cca,
                                      student_eca = Stud.student_eca,
                                      student_institution_id = Stud.student_institution_id,
                                      student_id = Stud.user_id,
                                  }).FirstOrDefault();

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Profile info" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                return studentProfile;
            }
            return studentProfile;
        }

        public void getSameSchoolClassFriendsList(int student_institution_id, int student_class)
        {
            
            try
            {
                
                var profile = (from User in objcubitEntities.userinfoes
                               join Stud in objcubitEntities.students on User.user_id equals Stud.user_id
                               where Stud.student_institution_id == student_institution_id && Stud.student_class == student_class
                               select new
                               {
                                   Stud.user_id,
                                   User.user_name
                               }).FirstOrDefault();

            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while getting Same School Class Friends List" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public IQueryable<UserPersonalInfo> getSameSchoolFriendsList(int user_id, int student_institution_id)
        {
            IQueryable<UserPersonalInfo> lstStudents = null;
            try
            {
                lstStudents = (from Frie in objcubitEntities.friends
                                         join Stud in objcubitEntities.students on Frie.to_user_id equals Stud.user_id
                                         join User in objcubitEntities.userinfoes on Stud.user_id equals User.user_id
                                         join UserPer in objcubitEntities.userpersonalinfoes on Stud.user_id equals UserPer.user_id
                                         where Frie.from_user_id == user_id && Stud.student_institution_id == student_institution_id
                                         select new UserPersonalInfo
                                         {
                                             user_id=User.user_id,
                                             user_name=User.user_name,
                                             userper_profile_pic=UserPer.userper_profile_pic,
                                         });
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching user same school friends list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstStudents;
        }

        public IQueryable<UserPersonalInfo> getDiffSchoolFriendsList(int user_id, int student_institution_id)
        {
            IQueryable<UserPersonalInfo> lstStudents = null;
            try
            {
                lstStudents = (from Frie in objcubitEntities.friends
                                         join Stud in objcubitEntities.students on Frie.to_user_id equals Stud.user_id
                                         join User in objcubitEntities.userinfoes on Stud.user_id equals User.user_id
                                         join UserPer in objcubitEntities.userpersonalinfoes on User.user_id equals UserPer.user_id
                                         where Frie.from_user_id == user_id && Stud.student_institution_id != student_institution_id
                                         select new UserPersonalInfo
                                         {
                                             user_id=User.user_id,
                                             user_name=User.user_name,
                                             userper_profile_pic=UserPer.userper_profile_pic,
   
                                         });
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching different school friends list " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstStudents;
        }

        /* ---------FETCH EVENTS,DOCUMENTS,LOCATION,FEEDS,POST--------------*/

        public void createEvent(EventPost events)
        {
            try
            {
                using (objcubitEntities)
                {
                    eventpost objEvent = new eventpost
                    {
                        event_title = events.event_title,
                        event_description = events.event_description,
                        event_startdate = events.event_startdate,
                        event_enddate = events.event_enddate,
                        event_document_id = events.event_document_id,
                        event_gpslocation_id = events.event_gpslocation_id,
                        event_venue = events.event_venue,
                        event_user_type = events.event_user_type,
                        user_id = events.user_id,
                    };
                    objcubitEntities.eventposts.Add(objEvent);
                    objcubitEntities.SaveChanges();
                }
            }catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving an event details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void uploadDocument(Document document)
        {
            try
            {
                using (objcubitEntities)
                {
                    document objDocument = new document
                    {
                        user_id = document.user_id,
                        doc_url= document.doc_url,
                        doc_name= document.doc_name,
                        doc_description= document.doc_description,
                        doc_uploaddate= document.doc_uploaddate,
                        doc_extension= document.doc_extension,
                        doc_size= document.doc_size,
                    };
                    objcubitEntities.documents.Add(objDocument);
                    objcubitEntities.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving an event details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addGPSLocation(GPSLocation location)
        {
            try
            {
                using (objcubitEntities)
                {
                    gpslocation objGPSLocation = new gpslocation
                    {
                        user_id= location.user_id,
                        gpslocation_discription = location.gpslocation_discription,
                        gpslocation_name= location.gpslocation_name,
                        gpslocation_location= location.gpslocation_location,
                    };
                    objcubitEntities.gpslocations.Add(objGPSLocation);
                    objcubitEntities.SaveChanges();
                }
                }catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving GPS location details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addPost(Post post)
        {
            try
            {
                using (objcubitEntities)
                {
                    post objPost = new post
                    {
                        user_id= post.user_id,
                        post_doc_id= post.post_doc_id,
                        post_gpslocation_id= post.post_gpslocation_id,
                        post_date= post.post_date,
                        post_user_type= post.post_user_type,
                        post_feeds= post.post_feeds,
                        post_tag_user_id= post.post_tag_user_id,
                        post_event_id= post.post_event_id,
                    };
                    objcubitEntities.posts.Add(objPost);
                    objcubitEntities.SaveChanges();
                }
            }catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }
       
        public List<eventpost> getUserEvents(int user_type)
        {
            List<eventpost> objEventPost = new List<eventpost>();
            try
            {
                using (objcubitEntities)
                {
                    objEventPost = objcubitEntities.eventposts.Where((e) => e.event_user_type == user_type).ToList();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching user type events ." + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return objEventPost;
        }

        public IQueryable<EventPost> getSameInstStudEvents(int student_institution_id)
        {
            IQueryable<EventPost> lstOfEvents = null;
            try
            {
                lstOfEvents= (from ev in objcubitEntities.eventposts
                              join st in objcubitEntities.students on ev.user_id equals st.user_id
                              where st.student_institution_id == student_institution_id
                              select new EventPost
                              {
                                  event_title = ev.event_title,
                                  event_description = ev.event_description,
                                  event_startdate = ev.event_startdate,
                                  event_enddate = ev.event_enddate,
                                  event_document_id = ev.event_document_id,
                                  event_gpslocation_id = ev.event_gpslocation_id,
                                  event_venue = ev.event_venue,
                                  event_user_type = ev.event_user_type,
                              });

            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching same institution students list of events " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return lstOfEvents;
        }
       
        public IQueryable<EventPost> getSameInstTeacherEvents(int teacher_institution_id)
        {
            IQueryable<EventPost> lstOfEvents = null;
            try
            {
                lstOfEvents= (from ev in objcubitEntities.eventposts
                              join t in objcubitEntities.teachers on ev.user_id equals t.user_id
                              where t.teacher_institution_id ==teacher_institution_id
                              select new EventPost
                              {
                                  event_title = ev.event_title,
                                  event_description = ev.event_description,
                                  event_startdate = ev.event_startdate,
                                  event_enddate = ev.event_enddate,
                                  event_document_id = ev.event_document_id,
                                  event_gpslocation_id = ev.event_gpslocation_id,
                                  event_venue = ev.event_venue,
                                  event_user_type = ev.event_user_type,
                              });

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching same institution teachers list of events " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return lstOfEvents;
        }

        public IQueryable<Post> getSameClassFriePost(int user_id,int student_class)
        {
            IQueryable<Post> lstOfPost = null;
            try
            {
                lstOfPost = (from po in objcubitEntities.posts
                             join fr in objcubitEntities.friends on po.user_id equals fr.from_user_id
                             join st in objcubitEntities.students on fr.from_user_id equals st.user_id
                             where fr.to_user_id == user_id || st.student_class == student_class
                             select new Post
                             {
                                 post_id = po.post_id,
                                 post_doc_id = po.post_doc_id,
                                 post_gpslocation_id = po.post_gpslocation_id,
                                 post_date = po.post_date,
                                 post_feeds = po.post_feeds,
                                 post_event_id = po.post_event_id,
                                 post_tag_user_id = po.post_tag_user_id,
                             });
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstOfPost;
        }

        public IQueryable<Post> getSameInstFriePost(int user_id, int institution_id)
        {
            IQueryable<Post> lstOfPost = null;
            try
            {
                lstOfPost= (from po in objcubitEntities.posts
                            join fr in objcubitEntities.friends on po.user_id equals fr.from_user_id
                            join t in objcubitEntities.teachers on fr.from_user_id equals t.user_id
                            where fr.to_user_id == user_id || t.teacher_institution_id == institution_id
                            select new Post
                            {
                                post_id = po.post_id,
                                post_doc_id = po.post_doc_id,
                                post_gpslocation_id = po.post_gpslocation_id,
                                post_date = po.post_date,
                                post_feeds = po.post_feeds,
                                post_event_id = po.post_event_id,
                                post_tag_user_id = po.post_tag_user_id,
                            });
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstOfPost;
        }     

        public IQueryable<Post> getStudentAnnouncement(int student_user_id, int institution_user_id)
        {
            IQueryable<Post> listOfAnnouncement = null;
            try
            {
               // listOfAnnouncement=
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Post details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return listOfAnnouncement;
        }

        /*-----------------------------------------------------------------------------HOME PAGE------------------------------------------------------*/

        public void addTimeTable(PeriodTimeTable periodTimeTable)
        {
            try
            {
                using (objcubitEntities)
                {
                    timetable objTimeTable = new timetable
                    {
                        timetable_id = periodTimeTable.timetable_id,
                        class_id = periodTimeTable.class_id,
                        section_id = periodTimeTable.section_id,
                        institution_id = periodTimeTable.institution_id,
                        isactive = periodTimeTable.isactive,
                        createdby = periodTimeTable.createdby,
                        createddate = periodTimeTable.createddate,
                    };
                    objcubitEntities.timetables.Add(objTimeTable);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving Timetable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addPeriodTimeTable(PeriodTimeTable periodtimetable)
        {
            try
            {
                using (objcubitEntities)
                {
                    periodtimetable objPeriodTimeTable = new periodtimetable
                    {
                        pttable_id = periodtimetable.pttable_id,
                        timetable_id = periodtimetable.timetable_id,
                        starttime = periodtimetable.starttime,
                        endtime = periodtimetable.endtime,
                        period_no = periodtimetable.period_no,
                        teacher_name = periodtimetable.teacher_name,
                        day = periodtimetable.day,
                        subject = periodtimetable.subject,
                    };
                    objcubitEntities.periodtimetables.Add(objPeriodTimeTable);
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving Timetable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public int getTimeTableid(int class_id, int section_id)
        {
            int timetableid = 0;
            try
            {               
                timetableid = objcubitEntities.timetables.Where((t) => t.class_id == class_id && t.section_id == section_id).Select((t) => t.timetable_id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while getting user id" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return timetableid;
        }

        public IQueryable<TimeTable> getTimeTable(int institution_id, int section_id, int class_id)
        {
            IQueryable<PeriodTimeTable> lstOfTimeTable = null;
            try
            {
                lstOfTimeTable = (from tt in objcubitEntities.timetables
                                  join ptt in objcubitEntities.periodtimetables on tt.timetable_id equals ptt.timetable_id
                                  where tt.class_id == class_id && tt.section_id == section_id && tt.institution_id == institution_id
                                  select new PeriodTimeTable
                                  {
                                      starttime = ptt.starttime,
                                      endtime = ptt.endtime,
                                      period_no = ptt.period_no,
                                      teacher_name = ptt.teacher_name,
                                      day = ptt.day,
                                      subject = ptt.subject,
                                  });
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching calender details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstOfTimeTable;
        }

        public IQueryable<TimeTable> getTeacherTimeTable(int institution_id, string teacher_name)
        {
            IQueryable<PeriodTimeTable> lstOfTimeTable = null;
            try
            {
                lstOfTimeTable = (from tt in objcubitEntities.timetables
                                  join ptt in objcubitEntities.periodtimetables on tt.timetable_id equals ptt.timetable_id
                                  where ptt.teacher_name == teacher_name && tt.institution_id == institution_id
                                  select new PeriodTimeTable
                                  {
                                      starttime = ptt.starttime,
                                      endtime = ptt.endtime,
                                      period_no = ptt.period_no,
                                      teacher_name = ptt.teacher_name,
                                      day = ptt.day,
                                      subject = ptt.subject,
                                  });
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching calender details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstOfTimeTable;
        }

        public void updateTimeTable(PeriodTimeTable periodTimeTable)
        {
            try
            {
                using (objcubitEntities)
                {

                    var updateTimeTable = objcubitEntities.periodtimetables.Where((p) => p.timetable_id == periodTimeTable.timetable_id).FirstOrDefault();
                    if (updateTimeTable != null)
                    {
                        updateTimeTable.starttime = periodTimeTable.starttime;
                        updateTimeTable.endtime = periodTimeTable.endtime;
                        updateTimeTable.period_no = periodTimeTable.period_no;
                        updateTimeTable.teacher_name = periodTimeTable.teacher_name;
                        updateTimeTable.day = periodTimeTable.day;
                        updateTimeTable.subject = periodTimeTable.subject;
                    }
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while updating updateTimeTable" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*---------------------------------------------------------------------------EXAM SCHEDULE----------------------------------------------------*/

        public void addExamReportMapping(ExamSchedule examSchedule)
        {
            try
            {
                using (objcubitEntities)
                {
                    examreportmapping objexamreportmapping = new examreportmapping
                    {
                        erm_section_id= examSchedule.erm_section_id,
                        erm_class_id= examSchedule.erm_class_id,
                        erm_institution_id= examSchedule.erm_institution_id,
                        exam_term= examSchedule.exam_term,
                    };
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving Timetable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addExamSchedule(ExamSchedule examSchedule)
        {
            try
            {
                using (objcubitEntities)
                {
                    examschedule objexamschedule = new examschedule
                    {
                        erm_id= examSchedule.erm_id,
                        subject_id= examSchedule.subject_id,
                        subject_name= examSchedule.subject_name,
                        exam_date= examSchedule.exam_date,
                        exam_term= examSchedule.exam_term,
                    };
                }
                }catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving Timetable details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public void addReportCard(ReportCard reportCard)
        {
            try
            {
                using (objcubitEntities)
                {
                    reportcard objexamreportcard = new reportcard
                    {
                        erm_id = reportCard.erm_id,
                        student_id = reportCard.student_id,
                        subject_id = reportCard.subject_id,
                        marks = reportCard.marks,
                        grade = reportCard.grade,
                        erm_term = reportCard.exam_term,
                    };
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while saving Student ReportCard details  " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public int getExamReportMappingid(int erm_institution_id,int erm_class_id,int erm_section_id,string exam_term)
        {
            int ExamReMapping = 0;
            try
            {              
                ExamReMapping = objcubitEntities.examreportmappings.Where((t) => t.erm_institution_id == erm_institution_id && t.erm_class_id == erm_class_id && t.erm_section_id == erm_section_id && t.exam_term == exam_term).Select((t) => t.erm_id).SingleOrDefault();
            }catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while getting ExamReportMappingid" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            
            return ExamReMapping;
        }

        public IQueryable<ReportCard> getStudentResult(int student_id, int institution_id, int class_id, int section_id)
        {
            IQueryable<ReportCard> objReportResult = null;
            try
            {
                objReportResult = (from erm in objcubitEntities.examreportmappings
                                   join es in objcubitEntities.examschedules on erm.erm_id equals es.erm_id
                                   join rc in objcubitEntities.reportcards on es.subject_id equals rc.subject_id
                                   where rc.student_id == student_id && erm.erm_institution_id == institution_id && erm.erm_class_id == class_id && erm.erm_section_id == section_id
                                   select new ReportCard
                                   {
                                       //subject_id = rc.subject_id,
                                       subject_name = es.subject_name,
                                       marks = rc.marks,
                                   }).Distinct();

                //          var total = objReportResult.Sum(rc=>rc.marks);


                //          var average=objReportResult.Average(rc=>rc.marks);

                //          var max=objReportResult.Max(rc=>rc.marks);


                //          var min=objReportResult.Min(rc=>rc.marks);

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Students Result " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return objReportResult;
        }

        public double getStudentPerformanceSameClass(int institution_id, int class_id, int section_id)
        {
            double Average = 0.0;
            try
            {
                Average = (from erm in objcubitEntities.examreportmappings
                           join es in objcubitEntities.examschedules on erm.erm_id equals es.erm_id
                           join rc in objcubitEntities.reportcards on es.subject_id equals rc.subject_id
                           where erm.erm_institution_id == institution_id && erm.erm_class_id == class_id && erm.erm_section_id == section_id
                           select new ReportCard
                           {
                               subject_id = rc.subject_id,
                               subject_name = es.subject_name,
                               marks = rc.marks,
                           }).Average(rc => rc.marks);

                //          var total = objReportResult.Sum(rc=>rc.marks);

                // Average = objReportResult.Average(rc=>rc.marks);

                //          var max=objReportResult.Max(rc=>rc.marks);

                //          var min=objReportResult.Min(rc=>rc.marks);

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching get Student Result Performance of Same Class " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }

            return Average;
        }

        /*----------------------------------------------------------------------------MY SLATE-----------------------------------------------------*/

        /*------------------HOME WORK----------------*/
        public void addHomeWork(HomeWork homework)
        {
            try
            {
                using (cubitEntities objcubitEntities = new cubitEntities())
                {
                    homework objHomeWork = new homework
                    {
                        hw_institution_id= homework.hw_institution_id,
                        hw_section_id = homework.hw_section_id,
                        hw_class_id = homework.hw_class_id,
                        hw_teacher_id = homework.hw_teacher_id,
                        hw_subject_id = homework.hw_subject_id,
                        hw_description = homework.hw_description,
                        hw_date = homework.hw_date,
                        isactive = homework.isactive,

                    };
                    objcubitEntities.homework.Add(objHomeWork);
                    objcubitEntities.SaveChanges();
                }

            }

            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while add HomeWork Announce" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public int getHomeWorkId(int teacher_id, int subject_id)
        {
            int homeworkid = 0;
            try
            {
                cubitEntities ab = new cubitEntities();
                homeworkid = ab.homework.Where((h) => h.hw_teacher_id == teacher_id && h.hw_subject_id == subject_id).Select((h) => h.homework_id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while getting Homework Announces id" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return homeworkid;
        }

        public void addHomeWorkUpload(HomeWorkUpload homeworkUpload)
        {
            try
            {
                using (cubitEntities objcubitEntities = new cubitEntities())
                {
                    homeworkupload objHomeWorkUpload = new homeworkupload
                    {
                        homework_id = homeworkUpload.homework_id,
                        hw_student_id = homeworkUpload.hw_student_id,
                        hw_url = homeworkUpload.hw_url,
                        isactive = homeworkUpload.isactive,
                    };
                    objcubitEntities.homeworkuploads.Add(objHomeWorkUpload);
                    objcubitEntities.SaveChanges();
                }

            }

            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while add HomeWork Upload" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        public IQueryable<HomeWorkUpload> getHomeworkSubmitedtoTeacher(int teacher_id)
        {

            IQueryable<HomeWorkUpload> lstOfHomework = null;
            try
            {
                lstOfHomework = (from hwa in objcubitEntities.homework
                                 join hwu in objcubitEntities.homeworkuploads on hwa.homework_id equals hwu.homework_id
                                 where hwa.hw_teacher_id == teacher_id
                                 select new HomeWorkUpload
                                 {
                                     hw_institution_id = hwa.hw_institution_id,
                                     hw_class_id = hwa.hw_class_id,
                                     hw_subject_id = hwa.hw_subject_id,
                                     hw_section_id = hwa.hw_section_id,
                                     hw_student_id = hwu.hw_student_id,
                                     hw_url = hwu.hw_url,
                                 });

            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Homework Submited to Teacher details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return lstOfHomework;
        }

        public void updateHomeWork(HomeWork objHomeWork)
        {
            try
            {
                using (objcubitEntities)
                {
                    var updateHomeWorkAnnounce = objcubitEntities.homework.Where((h) => h.hw_teacher_id == objHomeWork.hw_teacher_id && h.hw_subject_id == objHomeWork.hw_subject_id).FirstOrDefault();
                    if (updateHomeWorkAnnounce != null)
                    {
                        updateHomeWorkAnnounce.hw_description = objHomeWork.hw_description;
                        updateHomeWorkAnnounce.hw_date = objHomeWork.hw_date;
                    }
                    objcubitEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while updating updateTimeTable" + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }

        /*------------------MY PROJECT----------------*/

        /*------------------QUIZ----------------*/

        /*------------------COURSE MATERIAL----------------*/

        /*----------------------------------------------------------------------------INSTITUTION-----------------------------------------------------*/

        /*-----------------STUDENT DATABASE-----------------*/

        public IQueryable<Student> getStudentDatabase(int user_id)
        {
            IQueryable<Student> listOfStudentDatabase = null;
            
            try
            {
                listOfStudentDatabase = (from stu in objcubitEntities.students
                                             //join cls in objcubitEntities.classes on stu.student_class equals cls.class_id // requirment but not returning data 
                                             //join sec in objcubitEntities.sections on stu.student_section equals sec.section_name // requirment but not returning data
                                         join usin in objcubitEntities.userinfoes on stu.user_id equals usin.user_id
                                         join usper in objcubitEntities.userpersonalinfoes on usin.user_id equals usper.user_id
                                         
                                         where stu.student_institution_id == user_id
                                         select new Student
                                         {                                             
                                             user_name = usin.user_name,
                                             userper_dob = usper.userper_dob,
                                             userper_gender = usper.userper_gender,
                                             student_roll_no = stu.student_roll_no,
                                             student_cca = stu.student_cca,
                                             student_father_name = stu.student_father_name,
                                             student_mother_name = stu.student_mother_name,
                                             student_class=stu.student_class,
                                             student_id=stu.student_id,
                                         }
                                         
                                       );
                
            }
            catch(Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "DAL: Error while fetching Student database details " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
            return listOfStudentDatabase;
        }

    }
}
