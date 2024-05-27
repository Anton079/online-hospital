using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class ViewAdmin
    {
        private PatientService _patientService;
        private DoctorService _doctorService;
        private RegistrationSectionService _registrationSectionService;
        private SectionService _sectionService;
        private HospitalInformationService _hospitalInformationService;

        public ViewAdmin()
        {
            _patientService = new PatientService();
            _doctorService = new DoctorService();
            _registrationSectionService = new RegistrationSectionService();
            _sectionService = new SectionService();
            _hospitalInformationService = new HospitalInformationService();
        }

        public void MeniuAdmin()
        {
            Console.WriteLine("Apasati tasta 1 pentru a adauga un doctor");
            Console.WriteLine("Apasati tatsa 2 pentru a adauga o sectie la spital");
            Console.WriteLine("Apasati tasta 3 pentru edita programul spitalului");
            Console.WriteLine("Apasati tasta 4 pentru a edita numarul de telefon al unui doctor");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                MeniuAdmin();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    
                }
            }
        }
    }
}
