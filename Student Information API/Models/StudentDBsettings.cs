namespace Student_Information_API.Models
{
    public class StudentDBsettings : IStudentDBsettings
    {
        public string StudentCoursesCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
    
}
