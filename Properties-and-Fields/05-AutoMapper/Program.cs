// using System.ComponentModel;
// using System.Data;
// using System.IO.MemoryMappedFiles;
// using System.Reflection.Metadata.Ecma335;
// using AutoMapper;
// using System.Security.Cryptography;

// public class Program
// {
//     public class Student
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Email { get; set; }
//         public string Password { get; set; }
//     }

//     public class StudentDto
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Email { get; set; }
//         public string Password { get; set; }
//     }
//     public static void Main()
//     {
//         var s = new Student ()
//         {
//             Id = 5,
//             Name = "leen",
//             Password = "5555555",
//             Email = "leen2gmail.com"

//         };
//         var q = new StudentDto();
//         // CreateMap<Student, StudentDto>(); // Tell AutoMapper how Student should map to StudentDto
//          var config = new MapperConfiguration(cfg =>
//         {
//             cfg.CreateMap<Student, StudentDto>();
//         });
//           var mapper = config.CreateMapper();

//         var studentDto = mapper.Map<StudentDto>(s);

//         Console.WriteLine(studentDto.Name);
//         Console.WriteLine(studentDto.Email);
//         Console.WriteLine(studentDto.Password);
//         // var studentDto = mapper.Map<StudentDto>(q);
//         // Console.WriteLine(CheckStudent(student));
//         Console.WriteLine(studentDto);
//     }
// }
using AutoMapper;
using Microsoft.Extensions.Logging;

public class Program
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }
    
    public class UniStudent
    {
        public int Id { get; set; }
        public string FistName { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public static void Main()
    {
        var student = new Student
        {
            Id = 5,
            Name = "Leen",
            Email = "leen@gmail.com",
            Password = "5555555"
        };

        var loggerFactory = LoggerFactory.Create(builder => { });  // here we create a  builder  like in a .net  

        var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Student, StudentDto>();   //  here u make a mapper tell it copy the data from a Student to the StudentDto 
            },
            loggerFactory
        );
        var UniConfig = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Student, UniStudent>()
                    .ForMember(dest => dest.FistName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email));   //  here u make a mapper tell it copy the data from a Student to the StudentDto 
            },
            loggerFactory
        );

        var mapper = config.CreateMapper(); // know here we take copy of the mapperr we builds it 
        var Unimapper = UniConfig.CreateMapper();

        var uni = Unimapper.Map<UniStudent>(student);
        var studentDto = mapper.Map<StudentDto>(student);   // the actual copy here 

        Console.WriteLine(studentDto.Id);
        Console.WriteLine(studentDto.Name);
        Console.WriteLine(studentDto.Email);
        Console.WriteLine(studentDto.Password);
        
        Console.WriteLine(uni.Id);
        Console.WriteLine(uni.FistName);
        Console.WriteLine(uni.EmailAddress);
        Console.WriteLine(uni.Password);
    }
}