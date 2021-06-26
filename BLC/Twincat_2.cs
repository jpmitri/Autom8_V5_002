using System;
using System.Threading.Tasks;
using TwinCAT.Ads;

namespace BLC
{
    public partial class BLC
    {
        public String Twincat2Write(Params_Twincat2Write i_Params_Twincat2Write)
        {
            try
            {
                using (TcAdsClient tcAdsClient = new())
                {
                    AmsNetId amsNetId = new(i_Params_Twincat2Write.AMSID);
                    tcAdsClient.Connect(amsNetId, int.Parse(i_Params_Twincat2Write.Port));
                    int varibalehande = tcAdsClient.CreateVariableHandle(i_Params_Twincat2Write.VariableName);
                    tcAdsClient.WriteAny(varibalehande, Convert.ToByte(int.Parse(i_Params_Twincat2Write.Value)));
                    tcAdsClient.Dispose();
                    System.Threading.Thread.Sleep(250);
                    Params_Twincat2Read params_Twincat2Read = new();
                    params_Twincat2Read.AMSID = i_Params_Twincat2Write.AMSID;
                    params_Twincat2Read.Port = i_Params_Twincat2Write.Port;
                    params_Twincat2Read.VariableName = i_Params_Twincat2Write.VariableName;
                    string result = Twincat2Read(params_Twincat2Read);
                    if (result != i_Params_Twincat2Write.Value)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0002));
            }
        }
        public async Task<String> Twincat2Toggle(Params_Twincat2Toggle i_Params_Twincat2Toggle)
        {
            try
            {
                using (TcAdsClient tcAdsClient = new())
                {
                    AmsNetId amsNetId = new(i_Params_Twincat2Toggle.AMSID);
                    tcAdsClient.Connect(amsNetId, int.Parse(i_Params_Twincat2Toggle.Port));
                    int varibalehande = tcAdsClient.CreateVariableHandle(i_Params_Twincat2Toggle.VariableName);
                    tcAdsClient.WriteAny(varibalehande, Convert.ToByte(1));
                    tcAdsClient.Dispose();
                    System.Threading.Thread.Sleep(250);
                    Params_Twincat2Read params_Twincat2Read = new();
                    params_Twincat2Read.AMSID = i_Params_Twincat2Toggle.AMSID;
                    params_Twincat2Read.Port = i_Params_Twincat2Toggle.Port;
                    params_Twincat2Read.VariableName = i_Params_Twincat2Toggle.VariableName;
                    string result = Twincat2Read(params_Twincat2Read);
                    if (result != "1")
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    Task t = Task.Factory.StartNew(
                () =>
                                {
                                    System.Threading.Thread.Sleep(i_Params_Twincat2Toggle.Delay);
                                    tcAdsClient.Connect(amsNetId, int.Parse(i_Params_Twincat2Toggle.Port));
                                    varibalehande = tcAdsClient.CreateVariableHandle(i_Params_Twincat2Toggle.VariableName);
                                    tcAdsClient.WriteAny(varibalehande, Convert.ToByte(0));
                                    tcAdsClient.Dispose();
                                }
                        );
                    await t;

                    
                    System.Threading.Thread.Sleep(250);
                    result = Twincat2Read(params_Twincat2Read);
                    if (result != "0")
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    return result;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0002));
            }
        }
        public String Twincat2Read(Params_Twincat2Read i_Params_Twincat2Read)
        {
            try
            {
                using (TcAdsClient tcAdsClient = new())
                {
                    AmsNetId amsNetId = new(i_Params_Twincat2Read.AMSID);
                    tcAdsClient.Connect(amsNetId, int.Parse(i_Params_Twincat2Read.Port));
                    int varibalehande = tcAdsClient.CreateVariableHandle(i_Params_Twincat2Read.VariableName);
                    string res = tcAdsClient.ReadAny(varibalehande, varibalehande.GetType()).ToString(); ;
                    tcAdsClient.Dispose();
                    return res;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0002));
            }
        }
    }
    public partial class Params_Twincat2Write
    {
        public string VariableName { get; set; }
        public string Value { get; set; }
        public string AMSID { get; set; }
        public string Port { get; set; }
    }
    public partial class Params_Twincat2Toggle
    {
        public string VariableName { get; set; }
        public string AMSID { get; set; }
        public string Port { get; set; }
        public int Delay { get; set; }
    }
    public partial class Params_Twincat2Read
    {
        public string VariableName { get; set; }
        public string AMSID { get; set; }
        public string Port { get; set; }
    }
}
