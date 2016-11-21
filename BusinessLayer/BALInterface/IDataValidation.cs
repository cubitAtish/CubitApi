using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BALInterface
{
    public interface IDataValidation
    {
        bool validateName(string inputName);
        bool validateEmail(string inputEmail);
        bool checkValidateEmail(string inputEmail);
        bool validateDateOfBirth(DateTime dateOfBirth);
        bool getValidate(string inputstring);
        bool validatePhoneNo(string phoneNumber);
        bool validatePassword(string inputPassword);
    }
}
