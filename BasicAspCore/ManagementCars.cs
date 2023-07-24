namespace Lecture1
{
    public class ManagementCars : IManagementCars
    {
        public int GetCarAge()
        {
            return 20;
        }

        public string GetCarEngine()
        {
            return "very big engine";   
        }

        public string GetCarName()
        {
            return "very cool brand name";
        }
    }
}
