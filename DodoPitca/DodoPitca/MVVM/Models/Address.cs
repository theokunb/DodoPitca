using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.Models
{
    public abstract class Address
    {
        protected int id;
        protected string street;
        protected string house;

        public int Id
        {
            get => id;
        }

        public Address()
        {
            id = SetUniqueID();
        }
        protected int SetUniqueID()
        {
            int rand = new Random().Next();
            return DostavkaAddresses.IDs.Contains(rand) ? SetUniqueID() : rand;
        }
    }
}
