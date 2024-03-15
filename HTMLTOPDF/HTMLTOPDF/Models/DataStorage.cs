namespace HTMLTOPDF.Models
{
    public static class DataStorage
    {
        public static List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();

            for (int i = 0; i < 10000; i++)
            {
                employees.Add(new Employee
                {
                    NameRonak = $"Employee {i + 1}",
                    LastName = $"Last Name {i + 1}",
                    Age = 20 + i % 20, // Age from 20 to 39 in a cycle
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    // You can add more properties if needed
                    Images = GetBase64EncodedImage(),
                    Svg = GetSvgData()
                });
            }

            return employees;
        }

        private static string GetBase64EncodedImage()
        {
            // Replace this with your large image data in base64 format
            // For demonstration, I'm using a simple 1x1 transparent pixel
            return "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mNkAAIAAAoAAv/l" +
                   "QAAAAASUVORK5CYII=";
        }

        private static string GetSvgData()
        {
            // Replace this with your large SVG data
            // For demonstration, I'm using a simple SVG rectangle
            return "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"100\" height=\"100\">" +
                   "<rect width=\"100\" height=\"100\" style=\"fill:rgb(0,0,255);stroke-width:2;" +
                   "stroke:rgb(0,0,0)\" /></svg>";
        }
        //public static List<Employee> GetAllEmployees() =>
        //    new List<Employee>
        //    {
        //        new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"},
        //         new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"},
        //         new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"},
        //         new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"},
        //         new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}, new Employee { NameRonak="Mike", LastName="Turner", Age=35, Gender="Male"},
        //        new Employee { NameRonak="Sonja", LastName="Markus", Age=22, Gender="Female"},
        //        new Employee { NameRonak="Luck", LastName="Martins", Age=40, Gender="Male"},
        //        new Employee { NameRonak="Sofia", LastName="Packner", Age=30, Gender="Female"},
        //        new Employee { NameRonak="John", LastName="Doe", Age=45, Gender="Male"}
        //    };
    }
}
