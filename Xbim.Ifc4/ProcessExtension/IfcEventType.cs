// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEventType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEventType : IIfcTypeProcess
	{
		IfcEventTypeEnum @PredefinedType { get;  set; }
		IfcEventTriggerTypeEnum @EventTriggerType { get;  set; }
		IfcLabel? @UserDefinedEventTriggerType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IfcEventType", 1170)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEventType : IfcTypeProcess, IInstantiableEntity, IIfcEventType, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcEventType>
	{
		#region IIfcEventType explicit implementation
		IfcEventTypeEnum IIfcEventType.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IfcEventTriggerTypeEnum IIfcEventType.EventTriggerType { 
 
			get { return @EventTriggerType; } 
			set { EventTriggerType = value;}
		}	
		IfcLabel? IIfcEventType.UserDefinedEventTriggerType { 
 
			get { return @UserDefinedEventTriggerType; } 
			set { UserDefinedEventTriggerType = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEventType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcEventTypeEnum _predefinedType;
		private IfcEventTriggerTypeEnum _eventTriggerType;
		private IfcLabel? _userDefinedEventTriggerType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 19)]
		public IfcEventTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 20)]
		public IfcEventTriggerTypeEnum @EventTriggerType 
		{ 
			get 
			{
				if(_activated) return _eventTriggerType;
				Activate();
				return _eventTriggerType;
			} 
			set
			{
				SetValue( v =>  _eventTriggerType = v, _eventTriggerType, value,  "EventTriggerType", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcLabel? @UserDefinedEventTriggerType 
		{ 
			get 
			{
				if(_activated) return _userDefinedEventTriggerType;
				Activate();
				return _userDefinedEventTriggerType;
			} 
			set
			{
				SetValue( v =>  _userDefinedEventTriggerType = v, _userDefinedEventTriggerType, value,  "UserDefinedEventTriggerType", 12);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcEventTypeEnum) System.Enum.Parse(typeof (IfcEventTypeEnum), value.EnumVal, true);
					return;
				case 10: 
                    _eventTriggerType = (IfcEventTriggerTypeEnum) System.Enum.Parse(typeof (IfcEventTriggerTypeEnum), value.EnumVal, true);
					return;
				case 11: 
					_userDefinedEventTriggerType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEventType other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @HasPropertySets)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
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