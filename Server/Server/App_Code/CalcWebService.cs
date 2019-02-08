using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class CalcWebService : System.Web.Services.WebService
{
    [WebMethod]
    public int Soma(int X, int Y) => X + Y;

}
