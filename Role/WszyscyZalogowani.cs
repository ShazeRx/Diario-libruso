using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using static diario_libruso.Constants.Constants;

namespace diario_libruso.Role
{
    public class WszyscyZalogowani : AuthorizeAttribute
    {
        public WszyscyZalogowani()
        {
            Roles = String.Join(", ",
                new List<string>()
                {
                    Rola.UCZEN, Rola.RODZIC,
                    Rola.NAUCZYCIEL, Rola.ADMINISTRATOR
                });
        }
    }
}