//Generated file. Do not edit it manually.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DotnetT4PocoDsl.Commands
{
    public class AddDepartmentCommand : IEquatable<AddDepartmentCommand>
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IDictionary<string, string> CustomFields { get; set; }
        public XElement FieldsMeta { get; set; }

        public AddDepartmentCommand(string referenceNumber = default(string), string name = default(string), string description = default(string), IDictionary<string, string> customFields = default(IDictionary<string, string>), XElement fieldsMeta = default(XElement))
        {
            ReferenceNumber = referenceNumber;
            Name = name;
            Description = description;
            CustomFields = customFields;
            FieldsMeta = fieldsMeta;
        }

        public bool Equals(AddDepartmentCommand other)
        {
            return ReferenceNumber == other.ReferenceNumber &&
                   Name == other.Name &&
                   Description == other.Description &&
                   CustomFields.SequenceEqual(other.CustomFields) &&
                   XNode.DeepEquals(FieldsMeta, other.FieldsMeta);
        }

        public override string ToString()
        {
            return String.Concat("<AddDepartmentCommand ", "ReferenceNumber: ", ReferenceNumber, ", " , "Name: ", Name, ", " , "Description: ", Description, ", " , "CustomFields: ", CustomFields, ", " , "FieldsMeta: ", FieldsMeta, ">");
        }
    }

    public class UpdateDepartmentCommand : IEquatable<UpdateDepartmentCommand>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IDictionary<string, string> CustomFields { get; set; }
        public XElement FieldsMeta { get; set; }

        public UpdateDepartmentCommand(int id = default(int), string referenceNumber = default(string), string name = default(string), string description = default(string), IDictionary<string, string> customFields = default(IDictionary<string, string>), XElement fieldsMeta = default(XElement))
        {
            Id = id;
            ReferenceNumber = referenceNumber;
            Name = name;
            Description = description;
            CustomFields = customFields;
            FieldsMeta = fieldsMeta;
        }

        public bool Equals(UpdateDepartmentCommand other)
        {
            return Id == other.Id &&
                   ReferenceNumber == other.ReferenceNumber &&
                   Name == other.Name &&
                   Description == other.Description &&
                   CustomFields.SequenceEqual(other.CustomFields) &&
                   XNode.DeepEquals(FieldsMeta, other.FieldsMeta);
        }

        public override string ToString()
        {
            return String.Concat("<UpdateDepartmentCommand ", "Id: ", Id, ", " , "ReferenceNumber: ", ReferenceNumber, ", " , "Name: ", Name, ", " , "Description: ", Description, ", " , "CustomFields: ", CustomFields, ", " , "FieldsMeta: ", FieldsMeta, ">");
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
            return Id == other.Id &&
                   Reason == other.Reason;
        }

        public override string ToString()
        {
            return String.Concat("<RemoveDepartmentCommand ", "Id: ", Id, ", " , "Reason: ", Reason, ">");
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

        public DepartmentAdded(int id = default(int), string referenceNumber = default(string), string name = default(string), string description = default(string))
        {
            Id = id;
            ReferenceNumber = referenceNumber;
            Name = name;
            Description = description;
        }

        public bool Equals(DepartmentAdded other)
        {
            return Id == other.Id &&
                   ReferenceNumber == other.ReferenceNumber &&
                   Name == other.Name &&
                   Description == other.Description;
        }

        public override string ToString()
        {
            return String.Concat("<DepartmentAdded ", "Id: ", Id, ", " , "ReferenceNumber: ", ReferenceNumber, ", " , "Name: ", Name, ", " , "Description: ", Description, ">");
        }
    }

    public class DepartmentUpdated : IEquatable<DepartmentUpdated>
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DepartmentUpdated(int id = default(int), string referenceNumber = default(string), string name = default(string), string description = default(string))
        {
            Id = id;
            ReferenceNumber = referenceNumber;
            Name = name;
            Description = description;
        }

        public bool Equals(DepartmentUpdated other)
        {
            return Id == other.Id &&
                   ReferenceNumber == other.ReferenceNumber &&
                   Name == other.Name &&
                   Description == other.Description;
        }

        public override string ToString()
        {
            return String.Concat("<DepartmentUpdated ", "Id: ", Id, ", " , "ReferenceNumber: ", ReferenceNumber, ", " , "Name: ", Name, ", " , "Description: ", Description, ">");
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
            return Id == other.Id &&
                   Reason == other.Reason;
        }

        public override string ToString()
        {
            return String.Concat("<DepartmentRemoved ", "Id: ", Id, ", " , "Reason: ", Reason, ">");
        }
    }
}