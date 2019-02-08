using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApplication
{
    class Linklist
    {
        Node Header;
        Node Pointer;
        public Linklist()
        {
            Header = null;
            Pointer = null;
        }
        public void Add(string val)
        {
            var n = new Node(val);
            if (Header == null)
            {
                Header = n;
                Pointer = n;
            }
            else
            {
                Pointer.next = n;
                Pointer = Pointer.next;
            }

        }
        public void Save(Linklist ll)
        {
            var data = new ContactBookEntities();
            var personDetails = new ContactDetail()
            {
                PhoneNumber = ll.Header.data,
                Name = ll.Header.next.data,
                Email = ll.Header.next.next.data,
                Address = ll.Pointer.data
            };


            data.ContactDetails.Add(personDetails);
            data.SaveChanges();
        }

    }
}
