namespace OnionSeed.Factories
{
	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/>.
	/// </summary>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/>.
		/// </summary>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew();
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using one parameter.
	/// </summary>
	/// <typeparam name="T">The type of the parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameter.
		/// </summary>
		/// <param name="arg">The parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T arg);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using two parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using three parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using four parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using five parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using six parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using seven parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using eight parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using nine parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using ten parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using eleven parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T11">The type of the eleventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <param name="arg11">The eleventh parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using twelve parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T11">The type of the eleventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T12">The type of the twelfth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <param name="arg11">The eleventh parameter used to construct the instance.</param>
		/// <param name="arg12">The twelfth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using thirteen parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T11">The type of the eleventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T12">The type of the twelfth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T13">The type of the thirteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <param name="arg11">The eleventh parameter used to construct the instance.</param>
		/// <param name="arg12">The twelfth parameter used to construct the instance.</param>
		/// <param name="arg13">The thirteenth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using fourteen parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T11">The type of the eleventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T12">The type of the twelfth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T13">The type of the thirteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T14">The type of the fourteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <param name="arg11">The eleventh parameter used to construct the instance.</param>
		/// <param name="arg12">The twelfth parameter used to construct the instance.</param>
		/// <param name="arg13">The thirteenth parameter used to construct the instance.</param>
		/// <param name="arg14">The fourteenth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using fifteen parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T11">The type of the eleventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T12">The type of the twelfth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T13">The type of the thirteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T14">The type of the fourteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T15">The type of the fifteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <param name="arg11">The eleventh parameter used to construct the instance.</param>
		/// <param name="arg12">The twelfth parameter used to construct the instance.</param>
		/// <param name="arg13">The thirteenth parameter used to construct the instance.</param>
		/// <param name="arg14">The fourteenth parameter used to construct the instance.</param>
		/// <param name="arg15">The fifteenth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
	}

	/// <summary>
	/// Defines a mechanism that can be used to construct instances of a specified type <typeparamref name="TResult"/> using sixteen parameters.
	/// </summary>
	/// <typeparam name="T1">The type of the first parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T2">The type of the second parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T3">The type of the third parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T4">The type of the fourth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T5">The type of the fifth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T6">The type of the sixth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T7">The type of the seventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T8">The type of the eighth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T9">The type of the ninth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T10">The type of the tenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T11">The type of the eleventh parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T12">The type of the twelfth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T13">The type of the thirteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T14">The type of the fourteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T15">The type of the fifteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="T16">The type of the sixteenth parameter. This type parameter is contravariant.</typeparam>
	/// <typeparam name="TResult">The type to be constructed. This type parameter is covariant.</typeparam>
	public interface IFactory<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>
	{
		/// <summary>
		/// Creates a new instance of type <typeparamref name="TResult"/> using the given parameters.
		/// </summary>
		/// <param name="arg1">The first parameter used to construct the instance.</param>
		/// <param name="arg2">The second parameter used to construct the instance.</param>
		/// <param name="arg3">The third parameter used to construct the instance.</param>
		/// <param name="arg4">The fourth parameter used to construct the instance.</param>
		/// <param name="arg5">The fifth parameter used to construct the instance.</param>
		/// <param name="arg6">The sixth parameter used to construct the instance.</param>
		/// <param name="arg7">The seventh parameter used to construct the instance.</param>
		/// <param name="arg8">The eighth parameter used to construct the instance.</param>
		/// <param name="arg9">The ninth parameter used to construct the instance.</param>
		/// <param name="arg10">The tenth parameter used to construct the instance.</param>
		/// <param name="arg11">The eleventh parameter used to construct the instance.</param>
		/// <param name="arg12">The twelfth parameter used to construct the instance.</param>
		/// <param name="arg13">The thirteenth parameter used to construct the instance.</param>
		/// <param name="arg14">The fourteenth parameter used to construct the instance.</param>
		/// <param name="arg15">The fifteenth parameter used to construct the instance.</param>
		/// <param name="arg16">The sixteenth parameter used to construct the instance.</param>
		/// <returns>A new instance of type <typeparamref name="TResult"/>.</returns>
		TResult CreateNew(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
	}
}
