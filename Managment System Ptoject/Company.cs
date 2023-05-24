using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment_System_Ptoject
{
    class Company //company is the class that hold the company list of workers
    {
        public BindingList <Worker> _myCompanyList { get; set; }
        public string _companyName { get; set; }

        public int counter = 0;
        public Company(string name)
        {
            _myCompanyList = new BindingList<Worker>();
            _companyName = name;
        }
        public void AddWorker(Worker worker) //Add worker by the rellevant type of class and update his S.N
        {
            worker._serialNumber = ++counter;
            if(worker is Manager)
            {
                this._myCompanyList.Add((Manager)worker);
            }
            else if (worker is CleaningEmployee)
            {
                this._myCompanyList.Add((CleaningEmployee)worker);
            }
            else if (worker is MaintenanceEmployee)
            {
                this._myCompanyList.Add((MaintenanceEmployee)worker);
            }
            else if (worker is FinanceEmployee)
            {
                this._myCompanyList.Add((FinanceEmployee)worker);
            }
            else if (worker is ResourcesEmployee)
            {
                this._myCompanyList.Add((ResourcesEmployee)worker);
            }

        }
        public void RemoveWorker(int serialNumber)//Remove worker by S.N and update the S.N of the list
        {
            int i;
            for (i = serialNumber; i < _myCompanyList.Count; i++)
            {
                _myCompanyList[i]._serialNumber--;
            }
            counter--;
            this._myCompanyList.RemoveAt(serialNumber - 1);

        }


    }
}
