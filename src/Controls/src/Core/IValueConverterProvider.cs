using System;
using System.ComponentModel;
using System.Reflection;

namespace Microsoft.Maui.Controls.Xaml
{
	interface IValueConverterProvider
	{
		object Convert(object value, Type toType, Func<TypeConverter> getTypeConverter, IServiceProvider serviceProvider);
	}
}