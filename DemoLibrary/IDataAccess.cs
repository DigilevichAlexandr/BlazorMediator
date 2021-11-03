using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}