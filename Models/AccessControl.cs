using DM_SHEET.Data;
using DM_SHEET.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DM_SHEET.Data
{
    public class AccessControl
    {
        public int LoggedInAccountID { get; set; }
        public string LoggedInAccountName { get; set; }
    }
}
