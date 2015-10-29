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

        public AddDepartmentCommand(string referencenumber = default(string), string name = default(string), string description = default(string), IDictionary<string, string> customfields = default(IDictionary<string, string>), XElement fieldsmeta = default(XElement))
        {
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
            CustomFields = customfields;
            FieldsMeta = fieldsmeta;
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
            return string.Format("<AddDepartmentCommand ReferenceNumber: {0}, Name: {1}, Description: {2}, CustomFields: {3}, FieldsMeta: {4}>", ReferenceNumber, Name, Description, CustomFields, FieldsMeta);
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

        public UpdateDepartmentCommand(int id = default(int), string referencenumber = default(string), string name = default(string), string description = default(string), IDictionary<string, string> customfields = default(IDictionary<string, string>), XElement fieldsmeta = default(XElement))
        {
            Id = id;
            ReferenceNumber = referencenumber;
            Name = name;
            Description = description;
            CustomFields = customfields;
            FieldsMeta = fieldsmeta;
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
            return string.Format("<UpdateDepartmentCommand Id: {0}, ReferenceNumber: {1}, Name: {2}, Description: {3}, CustomFields: {4}, FieldsMeta: {5}>", Id, ReferenceNumber, Name, Description, CustomFields, FieldsMeta);
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
            return Id == other.Id &&
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
            return Id == other.Id &&
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
            return Id == other.Id &&
           Reason == other.Reason;
        }

        public override string ToString()
        {
            return string.Format("<DepartmentRemoved Id: {0}, Reason: {1}>", Id, Reason);
        }
    }
}