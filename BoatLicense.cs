namespace Sorbo_Assignment_7
{
    class BoatLicense
    {
        public string LicenseNum;
        public string State;
        public int MotorSizeInHP;
        public double LicFee;

        public BoatLicense(string LicenseNum, string State, int MotorSize, double LicFee)
        {
            this.LicenseNum = LicenseNum;
            this.State = State;
            this.MotorSizeInHP = MotorSize;
            this.LicFee = LicFee;
        }
    }
}