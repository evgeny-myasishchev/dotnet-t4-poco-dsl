//Generated file. Do not edit it manually.
using System;

namespace DotnetT4PocoDsl
{
    public partial class AddDepartment : IEquatable<AddDepartment>
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public AddDepartment()
        {
        }

        public AddDepartment(string aReferenceNumber = default(string),string aName = default(string),string aDescription = default(string))
        {
            ReferenceNumber = aReferenceNumber;
            Name = aName;
            Description = aDescription;
        }

        public bool Equals(AddDepartment other)
        {
            return
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<AddDepartment ReferenceNumber: {0}, Name: {1}, Description: {2}>", ReferenceNumber, Name, Description);
        }
    }

    public partial class UpdateDepartment : IEquatable<UpdateDepartment>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public UpdateDepartment()
        {
        }

        public UpdateDepartment(int aId = default(int),string aReferenceNumber = default(string),string aName = default(string),string aDescription = default(string))
        {
            Id = aId;
            ReferenceNumber = aReferenceNumber;
            Name = aName;
            Description = aDescription;
        }

        public bool Equals(UpdateDepartment other)
        {
            return
                Id == other.Id &&
                ReferenceNumber == other.ReferenceNumber &&
                Name == other.Name &&
                Description == other.Description;
        }

        public override string ToString()
        {
            return string.Format("<UpdateDepartment Id: {0}, ReferenceNumber: {1}, Name: {2}, Description: {3}>", Id, ReferenceNumber, Name, Description);
        }
    }

    public partial class RemoveDepartment : IEquatable<RemoveDepartment>
    {
        public int Id { get; set; }
        public string Reason { get; set; }

        public RemoveDepartment()
        {
        }

        public RemoveDepartment(int aId = default(int),string aReason = default(string))
        {
            Id = aId;
            Reason = aReason;
        }

        public bool Equals(RemoveDepartment other)
        {
            return
                Id == other.Id &&
                Reason == other.Reason;
        }

        public override string ToString()
        {
            return string.Format("<RemoveDepartment Id: {0}, Reason: {1}>", Id, Reason);
        }
    }
}
namespace DotnetT4PocoDsl
{
    public partial class DepartmentAdded : IEquatable<DepartmentAdded>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DepartmentAdded()
        {
        }

        public DepartmentAdded(int aId = default(int),string aReferenceNumber = default(string),string aName = default(string),string aDescription = default(string))
        {
            Id = aId;
            ReferenceNumber = aReferenceNumber;
            Name = aName;
            Description = aDescription;
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

    public partial class DepartmentUpdated : IEquatable<DepartmentUpdated>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DepartmentUpdated()
        {
        }

        public DepartmentUpdated(int aId = default(int),string aReferenceNumber = default(string),string aName = default(string),string aDescription = default(string))
        {
            Id = aId;
            ReferenceNumber = aReferenceNumber;
            Name = aName;
            Description = aDescription;
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

    public partial class DepartmentRemoved : IEquatable<DepartmentRemoved>
    {
        public int Id { get; set; }
        public string Reason { get; set; }

        public DepartmentRemoved()
        {
        }

        public DepartmentRemoved(int aId = default(int),string aReason = default(string))
        {
            Id = aId;
            Reason = aReason;
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