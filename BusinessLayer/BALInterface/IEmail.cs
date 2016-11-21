using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEntities;

namespace BusinessLayer.BALInterface
{
    public interface IEmail
    {
        void sendMails(UserInfo userInfo);
    }
}
