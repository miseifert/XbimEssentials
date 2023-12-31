// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcLibraryInformation", 449)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryInformation : PersistEntity, IInstantiableEntity, IfcLibrarySelect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcLibraryInformation>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLibraryInformation(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_libraryReference = new OptionalItemSet<IfcLibraryReference>( this, 0,  5);
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcLabel? _version;
		private IfcOrganization _publisher;
		private IfcCalendarDate _versionDate;
		private readonly OptionalItemSet<IfcLibraryReference> _libraryReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel? @Version 
		{ 
			get 
			{
				if(_activated) return _version;
				Activate();
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcOrganization @Publisher 
		{ 
			get 
			{
				if(_activated) return _publisher;
				Activate();
				return _publisher;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _publisher = v, _publisher, value,  "Publisher", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCalendarDate @VersionDate 
		{ 
			get 
			{
				if(_activated) return _versionDate;
				Activate();
				return _versionDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _versionDate = v, _versionDate, value,  "VersionDate", 4);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IOptionalItemSet<IfcLibraryReference> @LibraryReference 
		{ 
			get 
			{
				if(_activated) return _libraryReference;
				Activate();
				return _libraryReference;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_publisher = (IfcOrganization)(value.EntityVal);
					return;
				case 3: 
					_versionDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 4: 
					_libraryReference.InternalAdd((IfcLibraryReference)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLibraryInformation other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Publisher != null)
					yield return @Publisher;
				if (@VersionDate != null)
					yield return @VersionDate;
				foreach(var entity in @LibraryReference)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @LibraryReference)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}