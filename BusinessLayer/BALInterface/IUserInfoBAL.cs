using ClassEntities;
using DataAccessLayer;
using DataAccessLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BALInterface
{
    public interface IUserInfoBAL
    {

        /*-------------------------------------------------------------------------LOGIN/AUTHENTICATION-----------------------------*/
        void addAuthToken(Authtoken token);
        bool login(string email, string password);
        /*-------------------------------------------------------------------------USER REGISTRATION----------------------------------*/
        List<country> getCountry();
        List<state> getState(int countryId);
        List<city> getCity(int stateId);
        string addNewTeacher(Teacher userPerInfo);
        string addNewParent(Parent userPerInfo);
        string addNewStudent(Student userPerInfo);
        string addNewInstitute(Institution institution);
        /*------------------------------------------------------------------------CREATE GROUP-----------------------------------------*/
        void createGroup(Group objGroup);
        void sendGroupRequest(RequestStatus requestStatus);
        void updateRequest(RequestStatus requestStatus, EnumRequestStatus.requsetStatus status);
        void updateGroup(Group objGroup);
        void addUserToGroup(UserGroup userGroup);
        void rejectGroupRequest(UserGroup userGroup);
        void deleteGroup(Group objGroup);
        List<group> getUserGroupList(int userID);
        void userMemberGroup(UserGroup objGroup);
        /*--------------------------------------------------------------------------FORGOT PASSWORD--------------------------------------*/
        void generateLink(UserPersonalInfo userPerInfo);
        /*--------------------------------------------------------------------------CHANGE PASSWORD----------------------------------------*/
        void updatePassword(UserInfo userInfo);
        /*--------------------------------------------------------------------------PROFILE PAGE--------------------------------------------*/
        /* ----------FETCH PROFILE,FRIENDS,CLASSMEATS,SCHOOLMATES ----------*/
        void getSameSchoolClassFriendsList(int student_institution_id, int student_class);
        IQueryable<UserPersonalInfo> getSameSchoolFriendsList(int user_id, int student_institution_id);
        IQueryable<UserPersonalInfo> getDiffSchoolFriendsList(int user_id, int student_institution_id);
        Student getStudentProfileDetails(int student_institution_id);
        /* ---------FETCH EVENTS,DOCUMENTS,LOCATION,FEEDS,POST--------------*/
        void createEvent(EventPost events);
        void uploadDocument(Document document);
        void addGPSLocation(GPSLocation location);
        void addPost(Post post);       
        List<eventpost> getUserEvents(int user_type);
        IQueryable<EventPost> getSameInstStudEvents(int student_institution_id);
        IQueryable<EventPost> getSameInstTeacherEvents(int teacher_institution_id);
        IQueryable<Post> getSameClassFriePost(int user_id, int student_class);
        IQueryable<Post> getSameInstFriePost(int user_id, int institution_id);
        IQueryable<Post> getStudentAnnouncement(int student_user_id,int institution_user_id);
        /*-----------------------------------------------------------------------------HOME PAGE------------------------------------------------------*/
        string addTimeTable(PeriodTimeTable periodTimeTable);
        IQueryable<TimeTable> getTimeTable(int institution_id, int section_id, int class_id);
        IQueryable<TimeTable> getTeacherTimeTable(int institution_id, string teacher_name);
        void updateTimeTable(PeriodTimeTable periodTimeTable);
        /*----------------------------------------------------------------------------EXAM SCHEDULE-----------------------------------------------------*/
        string addExamSchedule(ExamSchedule examSchedule);
        string addReportCard(ReportCard reportCard);
        IQueryable<ReportCard> getStudentResult(int student_id, int institution_id, int class_id, int section_id);
        double getStudentPerformanceSameClass(int institution_id, int class_id, int section_id);
        /*----------------------------------------------------------------------------MY SLATE-----------------------------------------------------*/

        /*------------------HOME WORK----------------*/
        string addHomeWork(HomeWork homework);
        string addHomeWorkUpload(HomeWorkUpload homeworkUpload);
        IQueryable<HomeWorkUpload> getHomeworkSubmitedtoTeacher(int teacher_id);
        string updateHomeWork(HomeWork objHomeWorkAnnounce);
        /*------------------MY PROJECT----------------*/

        /*------------------QUIZ----------------*/

        /*------------------COURSE MATERIAL----------------*/

        /*----------------------------------------------------------------------------INSTITUTION-----------------------------------------------------*/

        /*----------------STUDENT DATABASE-----------------*/
        IQueryable<Student> getStudentDatabase(int user_id);

    }


}
