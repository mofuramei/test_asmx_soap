using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace test_asmx_soap
{
  /// <summary>
  /// WebService1 の概要の説明です
  /// </summary>
  [WebService(Namespace = "https://soap.testsv.jp/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // この Web サービスを、スクリプトから ASP.NET AJAX を使用して呼び出せるようにするには、次の行のコメントを解除します。
  // [System.Web.Script.Services.ScriptService]
  public class WebService1 : System.Web.Services.WebService
  {

    [WebMethod]
    public string HelloWorld()
    {
      return "Hello World test";
    }

    [WebMethod]
    public string AddQuote(string input)
    {
      return "\"" + input + "\"";
    }
  }
}
