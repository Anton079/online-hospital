using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class ViewDoctor
    {

        private Doctor doctor;
        private PatientService _patientService;
        private RegistrationSectionService _registrationSectionService;
        private SectionService _sectionService;
        private HospitalInformationService _hospitalInformationService;

        public ViewDoctor()
        {
            doctor = new Doctor(4, "Alex", "Bogdan", 0784482941);
            _patientService = new PatientService();
            _registrationSectionService = new RegistrationSectionService();
            _sectionService = new SectionService();
            _hospitalInformationService = new HospitalInformationService();
        }

        public void MeniuDoctor()
        {
            Console.WriteLine("Apasati tasta 1 pentru a vedea toti pacientii tai");
            Console.WriteLine("Apasati tasta 2 pentru a edita sectia unde se afla un pacient");
            Console.WriteLine("Apasati tasta 3 pentru a edita boala unui pacient");
            Console.WriteLine("Apasati tasta 4 pentru a edita gradul de sanatate al unui pacient");
            Console.WriteLine("Apasati tasta 5 pentru a arata pacientii dupa gradul de problema (bun-ok-rau)");
            Console.WriteLine("Apasati tasta 6 pentru a adauga un pacient intr-o sectie");
            Console.WriteLine("Apasati tasta 7 pentru a edita sectia unui pacient");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                MeniuDoctor();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        AfisareaPacientilorTai();
                        break;
                }
            }
        }

        public void AfisareaPacientilorTai()
        {
            int yourId = doctor.IdDoctor;

            if(yourId != 0)
            {
                List<int> yourPatient= _patientService.SortareaPacientilorTai(yourId);
                _patientService.AfisareaPacientilorTai(yourPatient);
            }
            else
            {
                Console.WriteLine("Pacientii nu au fost gasiti");
            }
        }
    }
}
