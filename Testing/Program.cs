using BraveHaxvius;
using BraveHaxvius.Data;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var b = new BraveExvius{};
            b.Login();
            var iw = b.Network.SendPacket(request: Request.EquipGrowEntry);
            Logger.Out($"Current Item : {iw[GameObject.EquipGrowEventInfo][0][Variable.EquipId].ToString()}");


        }
    }
}
