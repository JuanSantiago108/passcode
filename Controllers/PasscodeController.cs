using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using passcode.Models;

public class PasscodeController : Controller
{
    [HttpGet("/passcode")]
    public IActionResult GenerateCode()
    {
        int? count = HttpContext.Session.GetInt32("count");
        if (count == null)
        {
            HttpContext.Session.SetInt32("count", 1);
        }  
        PassCode newPassCode = new PassCode();
        return View("Generate", newPassCode);
    }

    [HttpPost("/passcode/create")]
    public IActionResult ResultCode()
    {
        int? count = HttpContext.Session.GetInt32("count");
        if (count == null) 
        {
            count = 1;
        }
        else 
        {
            count +=1;
        }
        HttpContext.Session.SetInt32("count",(int)count);
        return RedirectToAction("GenerateCode");
    }
}