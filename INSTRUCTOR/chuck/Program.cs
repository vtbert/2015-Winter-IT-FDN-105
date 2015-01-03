namespace chuck
{
    class Television
    {
        private int currentChannel;
        private int currentVolume;
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
        }

        public bool IsOn()
        {
            return isOn;
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public void ChangeChannel(int channel)
        {
            if (channel > 1 && channel < 14)
            {
                currentChannel = channel;
            }
        }

        public int GetChannel()
        {
            return currentChannel;
        }

        public void IncreaseVolume()
        {
            if (currentVolume < 100)
            {
                currentVolume++;
            }
        }

        public void DecreaseVolume()
        {
            if (currentVolume > 0)
            {
                currentVolume--;
            }
        }

        public int GetVolume()
        {
            return currentVolume;
        }
    }

    class Program
    {
        static void Main()
        {
            Television livingRoomTV = new Television();

            livingRoomTV.TurnOn();
            livingRoomTV.ChangeChannel(13);
            livingRoomTV.IncreaseVolume();
            livingRoomTV.IncreaseVolume();
            livingRoomTV.TurnOff();
        }
    }
}
