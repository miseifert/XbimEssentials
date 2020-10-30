// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.ConstraintResource;
using Xbim.Ifc4x3.PropertyResource;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.UtilityResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.UtilityResource
{
	[ExpressType("IfcTable", 377)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTable : PersistEntity, IInstantiableEntity, IfcMetricValueSelect, IfcObjectReferenceSelect, IContainsEntityReferences, IEquatable<@IfcTable>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTable(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_rows = new OptionalItemSet<IfcTableRow>( this, 0,  2);
			_columns = new OptionalItemSet<IfcTableColumn>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private readonly OptionalItemSet<IfcTableRow> _rows;
		private readonly OptionalItemSet<IfcTableColumn> _columns;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @Name 
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IOptionalItemSet<IfcTableRow> @Rows 
		{ 
			get 
			{
				if(_activated) return _rows;
				Activate();
				return _rows;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IOptionalItemSet<IfcTableColumn> @Columns 
		{ 
			get 
			{
				if(_activated) return _columns;
				Activate();
				return _columns;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcInteger @NumberOfCellsInRow 
		{
			get 
			{
				//## Getter for NumberOfCellsInRow
				//TODO: Implement getter for derived attribute NumberOfCellsInRow
				throw new NotImplementedException();
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcInteger @NumberOfHeadings 
		{
			get 
			{
				//## Getter for NumberOfHeadings
				//TODO: Implement getter for derived attribute NumberOfHeadings
				throw new NotImplementedException();
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcInteger @NumberOfDataRows 
		{
			get 
			{
				//## Getter for NumberOfDataRows
				//TODO: Implement getter for derived attribute NumberOfDataRows
				throw new NotImplementedException();
				//##
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
					_rows.InternalAdd((IfcTableRow)value.EntityVal);
					return;
				case 2: 
					_columns.InternalAdd((IfcTableColumn)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTable other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Rows)
					yield return entity;
				foreach(var entity in @Columns)
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