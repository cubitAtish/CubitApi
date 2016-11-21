using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BALInterface;
using ClassEntities;
using DataAccessLayer;
using DataAccessLayer.DALInterface;
using System.Text.RegularExpressions;
using ExceptionUtility;

namespace BusinessLayer
{
  public  class DataValidations : IDataValidation
    {

        public bool  validateName(string inputName)// applies for user_crby
        {
           
                string strRegex = @"^[a-zA-Z][a-zA-Z\\s]+$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(inputName))
                    return true;
                else
                    return false;
            
        }

        public bool validateEmail(string inputEmail)//applies for user_alternatemail
        {
            bool boolvalue = false;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
            {
                UserInfoBAL objUserInfoBAL = new UserInfoBAL();
                boolvalue = objUserInfoBAL.getEmailValidate(inputEmail);
            }   
            else
                return (false);           
            
            return boolvalue;
        }

        public bool checkValidateEmail(string inputEmail)
        {            
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
            {
                return (true);
            }
            else
                return (false);           
        }

        public bool validateDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth < System.DateTime.Today)           
           
                return  true;
            else
                return false;
            
        }

        public bool getValidate(string inputstring)// we can use this method for userper_sports, userper_hobbies,userper_personalities,userper_books,userper_movies
        {
            string strRegex = @"^[a-zA-Z][a-zA-Z\\s]+$"; // s
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputstring))
                return true;
            else
                return false;
        }

        public bool validatePhoneNo(string phoneNumber)// check indian phone numbers 
        {

            string strRegex = @"^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phoneNumber))
                return true;
            else
                return false;
        }

        public bool validatePassword(string inputPassword)
        {
            string strRegex = @"^.*(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*^.{8,12}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputPassword))
                return true;
            else
                return false;
        }

    }
}
