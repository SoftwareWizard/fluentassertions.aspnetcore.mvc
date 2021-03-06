using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FluentAssertions.AspNetCore.Mvc
{
    /// <summary>
    /// Contains a number of methods to assert that an <see cref="ActionResult"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class ActionResultAssertions : ObjectAssertions
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ActionResultAssertions" /> class.
        /// </summary>
        public ActionResultAssertions(ActionResult subject) : base(subject)
        {
            Subject = subject;
        }

        public ActionResultAssertions(IActionResult subject) : base(subject)
        {
            Subject = subject;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Asserts that the subject is a <see cref="ContentResult"/>.
        /// </summary>
        public ContentResultAssertions BeContentResult()
        {
            return BeContentResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="ContentResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public ContentResultAssertions BeContentResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is ContentResult)
                .FailWith(Constants.CommonFailMessage, typeof(ContentResult).Name, Subject.GetType().Name);

            return new ContentResultAssertions(Subject as ContentResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="EmptyResult"/>.
        /// </summary>
        public EmptyResult BeEmptyResult()
        {
            return BeEmptyResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="EmptyResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public EmptyResult BeEmptyResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is EmptyResult)
                .FailWith(Constants.CommonFailMessage, typeof(EmptyResult).Name, Subject.GetType().Name);

            return Subject as EmptyResult;
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileResult"/>.
        /// </summary>
        public FileResultAssertions BeFileResult()
        {
            return BeFileResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public FileResultAssertions BeFileResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is FileResult)
                .FailWith(Constants.CommonFailMessage, typeof(FileResult).Name, Subject.GetType().Name);

            return new FileResultAssertions(Subject as FileResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileContentResult"/>.
        /// </summary>
        public FileContentResultAssertions BeFileContentResult()
        {
            return BeFileContentResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileContentResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public FileContentResultAssertions BeFileContentResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is FileContentResult)
                .FailWith(Constants.CommonFailMessage, typeof(FileContentResult).Name, Subject.GetType().Name);

            return new FileContentResultAssertions(Subject as FileContentResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileStreamResult"/>.
        /// </summary>
        internal FileStreamResultAssertions BeFileStreamResult()
        {
            return BeFileStreamResult(string.Empty, null);

        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileStreamResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        internal FileStreamResultAssertions BeFileStreamResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is FileStreamResult)
                .FailWith(Constants.CommonFailMessage, typeof(FileStreamResult).Name, Subject.GetType().Name);

            return new FileStreamResultAssertions(Subject as FileStreamResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="PhysicalFileResult"/>.
        /// </summary>
        internal PhysicalFileResultAssertions BePhysicalFileResult()
        {
            return BePhysicalFileResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="FileStreamResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        internal PhysicalFileResultAssertions BePhysicalFileResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is PhysicalFileResult)
                .FailWith(Constants.CommonFailMessage, typeof(PhysicalFileResult).Name, Subject.GetType().Name);

            return new PhysicalFileResultAssertions(Subject as PhysicalFileResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="VirtualFileResult"/>.
        /// </summary>
        internal VirtualFileResultAssertions BeVirtualFileResult()
        {
            return BeVirtualFileResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="VirtualFileResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        internal VirtualFileResultAssertions BeVirtualFileResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is VirtualFileResult)
                .FailWith(Constants.CommonFailMessage, typeof(VirtualFileResult).Name, Subject.GetType().Name);

            return new VirtualFileResultAssertions(Subject as VirtualFileResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="JsonResult"/>.
        /// </summary>
        public JsonResultAssertions BeJsonResult()
        {
            return BeJsonResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="JsonResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public JsonResultAssertions BeJsonResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is JsonResult)
                .FailWith(Constants.CommonFailMessage, typeof(JsonResult).Name, Subject.GetType().Name);

            return new JsonResultAssertions(Subject as JsonResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectToRouteResult"/>.
        /// </summary>
        [CustomAssertion]
        public RedirectToRouteAssertions BeRedirectToRouteResult()
        {
            return BeRedirectToRouteResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectToRouteResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        [CustomAssertion]
        public RedirectToRouteAssertions BeRedirectToRouteResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is RedirectToRouteResult)
                .FailWith(Constants.CommonFailMessage, typeof(RedirectToRouteResult).Name, Subject.GetType().Name);

            return new RedirectToRouteAssertions(Subject as RedirectToRouteResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="PartialViewResult"/>.
        /// </summary>
        public PartialViewResultAssertions BePartialViewResult()
        {
            return BePartialViewResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="PartialViewResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public PartialViewResultAssertions BePartialViewResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is PartialViewResult)
                .FailWith(Constants.CommonFailMessage, typeof(PartialViewResult).Name, Subject.GetType().Name);

            return new PartialViewResultAssertions(Subject as PartialViewResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectResult"/>.
        /// </summary>
        public RedirectResultAssertions BeRedirectResult()
        {
            return BeRedirectResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public RedirectResultAssertions BeRedirectResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is RedirectResult)
                .FailWith(Constants.CommonFailMessage, "RedirectResult", Subject.GetType().Name);

            return new RedirectResultAssertions(Subject as RedirectResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="ViewResult"/>.
        /// </summary>
        public ViewResultAssertions BeViewResult()
        {
            return BeViewResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="ViewResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public ViewResultAssertions BeViewResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is ViewResult)
                .FailWith(Constants.CommonFailMessage, "ViewResult", Subject.GetType().Name);

            return new ViewResultAssertions(Subject as ViewResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectToActionResult"/>.
        /// </summary>
        public RedirectToActionResultAssertions BeRedirectToActionResult()
        {
            return BeRedirectToActionResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectToActionResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public RedirectToActionResultAssertions BeRedirectToActionResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is RedirectToActionResult)
                .FailWith(Constants.CommonFailMessage, "RedirectToActionResult", Subject.GetType().Name);

            return new RedirectToActionResultAssertions(Subject as RedirectToActionResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="StatusCodeResult"/>.
        /// </summary>
        public StatusCodeResultAssertions BeStatusCodeResult()
        {
            return BeStatusCodeResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="StatusCodeResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public StatusCodeResultAssertions BeStatusCodeResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                .BecauseOf(reason, reasonArgs)
                .ForCondition(Subject is StatusCodeResult)
                .FailWith(Constants.CommonFailMessage, "StatusCodeResult", Subject.GetType().Name);

            return new StatusCodeResultAssertions(Subject as StatusCodeResult);
        }

        #endregion Public Methods

        #region Public Structs

        public struct Constants
        {
            #region Public Fields

            public const string CommonFailMessage = "Expected ActionResult to be {0}{reason}, but found {1}";

            #endregion Public Fields
        }

        #endregion Public Structs
    }
}