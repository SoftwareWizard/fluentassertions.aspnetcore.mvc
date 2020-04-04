﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using Microsoft.AspNetCore.Mvc;
using AuthenticationProperties = Microsoft.AspNetCore.Authentication.AuthenticationProperties;

namespace FluentAssertions.AspNetCore.Mvc
{
    /// <summary>
    /// Contains a number of methods to assert that a <see cref="SignOutResult"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class SignOutResultAssertions : ObjectAssertions
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:SignOutResultAssertions" /> class.
        /// </summary>
        /// <param name="subject">The object to test assertion on</param>
        public SignOutResultAssertions(object subject) : base(subject)
        {
        }

        #endregion

        #region Public Properties
        public AuthenticationProperties AuthenticationProperties => SignOutResultSubject.Properties;
        public IDictionary<string, string> Items => SignOutResultSubject.Properties?.Items;
        public bool IsPersistent => SignOutResultSubject.Properties?.IsPersistent ?? false;
        public string RedirectUri => SignOutResultSubject.Properties?.RedirectUri;
        public DateTimeOffset? IssuedUtc => SignOutResultSubject.Properties?.IssuedUtc;
        public DateTimeOffset? ExpiresUtc => SignOutResultSubject.Properties?.ExpiresUtc;
        public bool? AllowRefresh => SignOutResultSubject.Properties?.AllowRefresh;
        public IList<string> AuthenticationSchemes => SignOutResultSubject.AuthenticationSchemes;
        #endregion

        #region Private Properties

        private SignOutResult SignOutResultSubject => (SignOutResult) Subject;

        #endregion

        #region Public Methods

        /// <summary>
        /// Asserts that the AuthenticationProperties is exactly the same as the expected AuthenticationProperties.
        /// </summary>
        /// <param name="expectedAuthenticationProperties">The expected AuthenticationProperties.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithAuthenticationProperties(AuthenticationProperties expectedAuthenticationProperties, string reason = "", params object[] reasonArgs)
        {
            var actualAuthenticationProperties = AuthenticationProperties;

            Execute.Assertion
                .ForCondition(actualAuthenticationProperties == expectedAuthenticationProperties)
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties", expectedAuthenticationProperties, actualAuthenticationProperties));

            return this;
        }

        /// <summary>
        /// Asserts that the IsPersistent is exactly the same as the expected IsPersistent.
        /// </summary>
        /// <param name="expectedIsPersistent">The expected IsPersistent.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithIsPersistent(bool expectedIsPersistent, string reason = "", params object[] reasonArgs)
        {
            var actualIsPersistent = IsPersistent;

            Execute.Assertion
                .ForCondition(actualIsPersistent == expectedIsPersistent)
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.IsPersistent", expectedIsPersistent, actualIsPersistent));

            return this;
        }

        /// <summary>
        /// Asserts that the RedirectUri is exactly the same as the expected RedirectUri.
        /// </summary>
        /// <param name="expectedRedirectUri">The expected RedirectUri.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithRedirectUri(string expectedRedirectUri, string reason = "", params object[] reasonArgs)
        {
            var actualRedirectUri = RedirectUri;

            Execute.Assertion
                .ForCondition(string.Equals(actualRedirectUri, expectedRedirectUri))
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.RedirectUri", expectedRedirectUri, actualRedirectUri));

            return this;
        }

        /// <summary>
        /// Asserts that the IssuedUtc is exactly the same as the expected IssuedUtc.
        /// </summary>
        /// <param name="expectedIssuedUtc">The expected IssuedUtc.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithIssuedUtc(DateTimeOffset? expectedIssuedUtc, string reason = "", params object[] reasonArgs)
        {
            var actualResult = IssuedUtc;

            var expectedIssuedUtcAsString = expectedIssuedUtc?.ToString("r", (IFormatProvider) CultureInfo.InvariantCulture);
            
            var expectedResult = DateTimeOffset.TryParseExact(expectedIssuedUtcAsString, "r", (IFormatProvider)CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result) 
                ? new DateTimeOffset?(result)
                : new DateTimeOffset?();

            if (actualResult == null && expectedResult == null)
            {
                return this;
            }

            if (actualResult == null)
            {
                Execute.Assertion
                    .ForCondition(false)
                    .BecauseOf(reason, reasonArgs)
                    .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.IssuedUtc", expectedResult, null));

                return this;
            }

            if (expectedResult == null)
            {
                Execute.Assertion
                    .ForCondition(false)
                    .BecauseOf(reason, reasonArgs)
                    .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.IssuedUtc", null, actualResult));

                return this;
            }

            Execute.Assertion
                .ForCondition(DateTimeOffset.Compare(expectedResult.Value, actualResult.Value) == 0)
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.IssuedUtc", expectedResult.Value, actualResult.Value));

            return this;
        }

        /// <summary>
        /// Asserts that the ExpiresUtc is exactly the same as the expected ExpiresUtc.
        /// </summary>
        /// <param name="expectedExpiresUtc">The expected ExpiresUtc.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithExpiresUtc(DateTimeOffset? expectedExpiresUtc, string reason = "", params object[] reasonArgs)
        {
            var actualResult = ExpiresUtc;

            var expectedExpiresUtcAsString = expectedExpiresUtc?.ToString("r", (IFormatProvider)CultureInfo.InvariantCulture);

            var expectedResult = DateTimeOffset.TryParseExact(expectedExpiresUtcAsString, "r", (IFormatProvider)CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result)
                ? new DateTimeOffset?(result)
                : new DateTimeOffset?();

            if (actualResult == null && expectedResult == null)
            {
                return this;
            }

            if (actualResult == null)
            {
                Execute.Assertion
                    .ForCondition(false)
                    .BecauseOf(reason, reasonArgs)
                    .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.ExpiresUtc", expectedResult, null));

                return this;
            }

            if (expectedResult == null)
            {
                Execute.Assertion
                    .ForCondition(false)
                    .BecauseOf(reason, reasonArgs)
                    .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.ExpiresUtc", null, actualResult));

                return this;
            }

            Execute.Assertion
                .ForCondition(DateTimeOffset.Compare(expectedResult.Value, actualResult.Value) == 0)
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.ExpiresUtc", expectedResult.Value, actualResult.Value));

            return this;
        }


        /// <summary>
        /// Asserts that the AllowRefresh is exactly the same as the expected AllowRefresh.
        /// </summary>
        /// <param name="expectedAllowRefresh">The expected AllowRefresh.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithAllowRefresh(bool? expectedAllowRefresh, string reason = "", params object[] reasonArgs)
        {
            var actualAllowRefresh = AllowRefresh;

            Execute.Assertion
                .ForCondition(actualAllowRefresh == expectedAllowRefresh)
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonFailMessage, "SignOutResult.AuthenticationProperties.AllowRefresh", expectedAllowRefresh, actualAllowRefresh));

            return this;
        }

        /// <summary>
        /// Asserts that the Items contain the the expected Key Value Pair.
        /// </summary>
        /// <param name="expectedKey">The expected Key in Items.</param>
        /// <param name="expectedValue">The expected Value in Items.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions ContainsItem(string expectedKey, string expectedValue, string reason = "", params object[] reasonArgs)
        {
            var actualItems = Items;
            var keyValuePair = new KeyValuePair<string, string>(expectedKey, expectedValue);

            Execute.Assertion
                .ForCondition(actualItems.Contains(keyValuePair))
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonItemsContain, expectedKey, expectedValue));

            return this;
        }

        /// <summary>
        /// Asserts that the AuthenticationSchemes is exactly the same as the expected AuthenticationSchemes.
        /// </summary>
        /// <param name="expectedAuthenticationSchemes">The expected AuthenticationSchemes.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions WithAuthenticationSchemes(IList<string> expectedAuthenticationSchemes, string reason = "", params object[] reasonArgs)
        {
            var actualAuthenticationSchemes = AuthenticationSchemes;

            var difference1 = actualAuthenticationSchemes.Except(expectedAuthenticationSchemes);
            var difference2 = expectedAuthenticationSchemes.Except(actualAuthenticationSchemes);

            Execute.Assertion
                .ForCondition(!difference1.Any() && !difference2.Any())
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonListsNotIdentical, "SignOutResult.AuthenticationSchemes"));

            return this;
        }

        /// <summary>
        /// Asserts that the Authentication Schemes contain the the expected scheme.
        /// </summary>
        /// <param name="expectedScheme">The expected scheme.</param>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public SignOutResultAssertions ContainsScheme(string expectedScheme, string reason = "", params object[] reasonArgs)
        {
            var actualSchemes = AuthenticationSchemes;

            Execute.Assertion
                .ForCondition(actualSchemes.Contains(expectedScheme))
                .BecauseOf(reason, reasonArgs)
                .FailWith(string.Format(FailureMessages.CommonAuthenticationSchemesContainScheme, expectedScheme));

            return this;
        }

        #endregion
    }
}