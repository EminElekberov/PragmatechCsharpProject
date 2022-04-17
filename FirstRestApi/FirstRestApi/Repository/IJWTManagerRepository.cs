using FirstRestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRestApi.Repository
{
    public interface IJWTManagerRepository
    {
        Token Authontentication(Users users);
    }
}
