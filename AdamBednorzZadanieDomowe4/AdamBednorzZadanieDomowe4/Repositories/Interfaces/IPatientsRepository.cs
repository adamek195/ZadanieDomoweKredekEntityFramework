using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// interfejs gdzie deklarowane są metody do odslugi z tabela pacjentów
    /// </summary>
    public interface IPatientsRepository
    {
        /// <summary>
        /// definicja metody pozwalajacej sie zalogować do systemu
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool SignIn(string firstName, string lastName, string password);
        /// <summary>
        /// definicja metody pozwalajacej utworzyc konto pacjenta
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Register(string firstName, string lastName, string password);
        /// <summary>
        /// definicja metody pozwalajacej usunąć konto pacjenta
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool DeletePatient(string firstName, string lastName, string password);
        /// <summary>
        /// definicja metody pozwalajacej zmienić hasło pacjenta w bazie
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool ChangePassword(string firstName, string lastName, string password, string newPassword);
    }
}
