//Generated file. Do not edit it manually.
using System;

namespace DotnetT4PocoDsl.Commands
{
    public class AddDepartmentCommand : IEquatable<AddDepartmentCommand>
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public AddDepartmentCommand(string referencenumber = default(string), string name = default(string), string description = default(string))
        {
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
        }

        public bool Equals(AddDepartmentCommand other)
        {
            return
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<AddDepartmentCommand ReferenceNumber: {0}, Name: {1}, Description: {2}>", ReferenceNumber, Name, Description);
        }
    }

    public class AddDepartmentCommand1 : IEquatable<AddDepartmentCommand1>
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public AddDepartmentCommand1(string referencenumber = default(string), string name = default(string), string description = default(string))
        {
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
        }

        public bool Equals(AddDepartmentCommand1 other)
        {
            return
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<AddDepartmentCommand1 ReferenceNumber: {0}, Name: {1}, Description: {2}>", ReferenceNumber, Name, Description);
        }
    }

    public class AddDepartmentCommand2 : IEquatable<AddDepartmentCommand2>
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public AddDepartmentCommand2(string referencenumber = default(string), string name = default(string), string description = default(string))
        {
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
        }

        public bool Equals(AddDepartmentCommand2 other)
        {
            return
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<AddDepartmentCommand2 ReferenceNumber: {0}, Name: {1}, Description: {2}>", ReferenceNumber, Name, Description);
        }
    }

    public class UpdateDepartmentCommand : IEquatable<UpdateDepartmentCommand>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public UpdateDepartmentCommand(int id = default(int), string referencenumber = default(string), string name = default(string), string description = default(string))
        {
            Id = id;
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
        }

        public bool Equals(UpdateDepartmentCommand other)
        {
            return
                Id == other.Id &&
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<UpdateDepartmentCommand Id: {0}, ReferenceNumber: {1}, Name: {2}, Description: {3}>", Id, ReferenceNumber, Name, Description);
        }
    }

    public class RemoveDepartmentCommand : IEquatable<RemoveDepartmentCommand>
    {
        public int Id { get; set; }
        public string Reason { get; set; }

        public RemoveDepartmentCommand(int id = default(int), string reason = default(string))
        {
            Id = id;
            Reason = reason;
        }

        public bool Equals(RemoveDepartmentCommand other)
        {
            return
                Id == other.Id &&
                Reason == other.Reason;
        }

        public override string ToString()
        {
            return string.Format("<RemoveDepartmentCommand Id: {0}, Reason: {1}>", Id, Reason);
        }
    }
}
namespace DotnetT4PocoDsl.Events
{
    public class DepartmentAdded : IEquatable<DepartmentAdded>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DepartmentAdded(int id = default(int), string referencenumber = default(string), string name = default(string), string description = default(string))
        {
            Id = id;
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
        }

        public bool Equals(DepartmentAdded other)
        {
            return
                Id == other.Id &&
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<DepartmentAdded Id: {0}, ReferenceNumber: {1}, Name: {2}, Description: {3}>", Id, ReferenceNumber, Name, Description);
        }
    }

    public class DepartmentUpdated : IEquatable<DepartmentUpdated>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DepartmentUpdated(int id = default(int), string referencenumber = default(string), string name = default(string), string description = default(string))
        {
            Id = id;
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
        }

        public bool Equals(DepartmentUpdated other)
        {
            return
                Id == other.Id &&
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<DepartmentUpdated Id: {0}, ReferenceNumber: {1}, Name: {2}, Description: {3}>", Id, ReferenceNumber, Name, Description);
        }
    }

    public class DepartmentRemoved : IEquatable<DepartmentRemoved>
    {
        public int Id { get; set; }
        public string Reason { get; set; }

        public DepartmentRemoved(int id = default(int), string reason = default(string))
        {
            Id = id;
            Reason = reason;
        }

        public bool Equals(DepartmentRemoved other)
        {
            return
                Id == other.Id &&
                Reason == other.Reason;
        }

        public override string ToString()
        {
            return string.Format("<DepartmentRemoved Id: {0}, Reason: {1}>", Id, Reason);
        }
    }
}