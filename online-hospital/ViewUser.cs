using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class ViewUser
    {
        private Patient patient;
        private DoctorService _doctorService;
        private RegistrationSectionService _registrationSectionService;
        private SectionService _sectionService;
        private HospitalInformationService _hospitalInformationService;

        public ViewUser()
        {
            patient = new Patient(5, "Mihnea", "Raul", "varicela", "mediu", 20052025, 3);
            _doctorService = new DoctorService();
            _registrationSectionService = new RegistrationSectionService();
            _sectionService = new SectionService();
            _hospitalInformationService = new HospitalInformationService();
        }

        public void MeniuUser()
        {
            Console.WriteLine("Apasati tasta 1 pentru a vedea problema de sanatate");
            Console.WriteLine("Apasati tasta 2 pentru a vedea sectia pe care se afla pacientul");
            Console.WriteLine("Apasati tasta 3 pentru a vedea gradul de problema al pacientului (bun-ok-rau)");
            Console.WriteLine("Apasati tasta 4 pentru a vedea programul de vizita si alte informatii de contact");
            Console.WriteLine("Apasati tasta 5 pentru a programa o vizita la pacient");
        }

        public void play()
        {
            bool running = true;
            while(running)
            {
                MeniuUser();
                string alegere = Console.ReadLine();

                switch (alegere)
                {

                }
            }
        }
    }
}
