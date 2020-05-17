﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maktoob.CrossCuttingConcerns.Properties {
    using System;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorEx custom tool.
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorEx custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2020 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DMKSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "2.6.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
#if !SILVERLIGHT
    [global::System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=true)]
#endif
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public partial class Errors {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        /// <summary>
        /// Initializes a Errors object.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Errors() {
        }
        
        /// <summary>
        /// Thread safe lock object used by this class.
        /// </summary>
        public static object InternalSyncObject {
            get {
                if (object.ReferenceEquals(_internalSyncObject, null)) {
                    global::System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                }
                return _internalSyncObject;
            }
        }
        
        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(_resourceManager, null)) {
                    global::System.Threading.Monitor.Enter(InternalSyncObject);
                    try {
                        if (object.ReferenceEquals(_resourceManager, null)) {
                            global::System.Threading.Interlocked.Exchange(ref _resourceManager, new global::System.Resources.ResourceManager("Maktoob.CrossCuttingConcerns.Properties.Errors", typeof(Errors).Assembly));
                        }
                    }
                    finally {
                        global::System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return _resourceCulture;
            }
            set {
                _resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Optimistic concurrency failure, object has been modified.'.
        /// </summary>
        public static string ConcurrencyFailure {
            get {
                return ResourceManager.GetString(ResourceNames.ConcurrencyFailure, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An unknown failure has occurred.'.
        /// </summary>
        public static string DefaultError {
            get {
                return ResourceManager.GetString(ResourceNames.DefaultError, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Email &apos;{0}&apos; is already taken.'.
        /// </summary>
        public static string DuplicateEmail {
            get {
                return ResourceManager.GetString(ResourceNames.DuplicateEmail, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'User name &apos;{0}&apos; is already taken.'.
        /// </summary>
        public static string DuplicateUserName {
            get {
                return ResourceManager.GetString(ResourceNames.DuplicateUserName, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Invalid user name or password.'.
        /// </summary>
        public static string InvalidCredentials {
            get {
                return ResourceManager.GetString(ResourceNames.InvalidCredentials, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Email &apos;{0}&apos; is invalid.'.
        /// </summary>
        public static string InvalidEmail {
            get {
                return ResourceManager.GetString(ResourceNames.InvalidEmail, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to '{0}'.
        /// </summary>
        public static string InvalidToken {
            get {
                return ResourceManager.GetString(ResourceNames.InvalidToken, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'User name &apos;{0}&apos; is invalid, can only contain letters or digits.'.
        /// </summary>
        public static string InvalidUserName {
            get {
                return ResourceManager.GetString(ResourceNames.InvalidUserName, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'A user with this login already exists.'.
        /// </summary>
        public static string LoginAlreadyAssociated {
            get {
                return ResourceManager.GetString(ResourceNames.LoginAlreadyAssociated, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'No results found.'.
        /// </summary>
        public static string NotFound {
            get {
                return ResourceManager.GetString(ResourceNames.NotFound, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'You cannot log out now. Please try again in a moment.'.
        /// </summary>
        public static string SignOutFailed {
            get {
                return ResourceManager.GetString(ResourceNames.SignOutFailed, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Email &apos;{0}&apos; is already taken.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string DuplicateEmailFormat(object arg0) {
            return string.Format(_resourceCulture, DuplicateEmail, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'User name &apos;{0}&apos; is already taken.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string DuplicateUserNameFormat(object arg0) {
            return string.Format(_resourceCulture, DuplicateUserName, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Email &apos;{0}&apos; is invalid.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string InvalidEmailFormat(object arg0) {
            return string.Format(_resourceCulture, InvalidEmail, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to '{0}'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string InvalidTokenFormat(object arg0) {
            return string.Format(_resourceCulture, InvalidToken, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'User name &apos;{0}&apos; is invalid, can only contain letters or digits.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string InvalidUserNameFormat(object arg0) {
            return string.Format(_resourceCulture, InvalidUserName, arg0);
        }
        
        /// <summary>
        /// Lists all the resource names as constant string fields.
        /// </summary>
        public class ResourceNames {
            
            /// <summary>
            /// Stores the resource name 'ConcurrencyFailure'.
            /// </summary>
            public const string ConcurrencyFailure = "ConcurrencyFailure";
            
            /// <summary>
            /// Stores the resource name 'DefaultError'.
            /// </summary>
            public const string DefaultError = "DefaultError";
            
            /// <summary>
            /// Stores the resource name 'DuplicateEmail'.
            /// </summary>
            public const string DuplicateEmail = "DuplicateEmail";
            
            /// <summary>
            /// Stores the resource name 'DuplicateUserName'.
            /// </summary>
            public const string DuplicateUserName = "DuplicateUserName";
            
            /// <summary>
            /// Stores the resource name 'InvalidCredentials'.
            /// </summary>
            public const string InvalidCredentials = "InvalidCredentials";
            
            /// <summary>
            /// Stores the resource name 'InvalidEmail'.
            /// </summary>
            public const string InvalidEmail = "InvalidEmail";
            
            /// <summary>
            /// Stores the resource name 'InvalidToken'.
            /// </summary>
            public const string InvalidToken = "InvalidToken";
            
            /// <summary>
            /// Stores the resource name 'InvalidUserName'.
            /// </summary>
            public const string InvalidUserName = "InvalidUserName";
            
            /// <summary>
            /// Stores the resource name 'LoginAlreadyAssociated'.
            /// </summary>
            public const string LoginAlreadyAssociated = "LoginAlreadyAssociated";
            
            /// <summary>
            /// Stores the resource name 'NotFound'.
            /// </summary>
            public const string NotFound = "NotFound";
            
            /// <summary>
            /// Stores the resource name 'SignOutFailed'.
            /// </summary>
            public const string SignOutFailed = "SignOutFailed";
        }
    }
}
