﻿namespace HomeCinema.Services.Abstract
{
    public interface IEncryptionService
    {
        string CreateSalt();

        string EncryptPassword(string password, string salt);
    }
}