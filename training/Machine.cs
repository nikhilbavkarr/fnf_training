using System;
using System.Collections.Generic;
using System.Linq;

class Machine{

        public string SlNo{ get; set; }
        
        public string Make{ get; set; }

        public string Model{ get; set; }

        public  int Price{ get; set; }

       public override string ToString(){
            return string.Format("The slno:{0} \nThe Make:{1} \nThe model:{2} \nThe price:{3}",SlNo,Make,Model,Price);
        }
    }

    class MachineDatabase{
        private List<Machine> laptop=new List<Machine>();
        
        public void RegisterDevice(Machine mac){
            laptop.Add(mac);
        }
        public void UpdateDeviceDetails(string slno,Machine mac){
            foreach ( var items in laptop)
            {
                if(items.SlNo==slno)
                {
                    items.Make=mac.Make;
                    items.Model=mac.Model;
                    items.Price=mac.Price;
                    break;
                }
            }
        }
        public List<Machine> GetAllRegisteredDevices(){
            return laptop;
        }
        public void DeleteMachine(string slno){
            Machine machinetodelete = null;
            foreach(var machines in laptop)
            {
                machinetodelete = machines;
                break;
            }
            if(machinetodelete != null)
            {
                laptop.Remove(machinetodelete);
            }
        }
    }