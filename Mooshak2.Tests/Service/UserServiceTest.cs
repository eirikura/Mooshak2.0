using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mooshak2.Services;
using Mooshak2.Models.ViewModel;

namespace Mooshak2.Tests.Service
{
    [TestClass]
    public class UserServiceTest
    {
        private AccountsService _service = new AccountsService();
        private SubmissionsService _subService = new SubmissionsService();

        [TestMethod]
        public void TestAddSubmissionReview()
        {
            // Arrange:
            const int submissionID = 10;
            const int reviewID = 10;

            // Act:
            var result = _subService.addSubmissionReview(submissionID, reviewID);

            // Assert:
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAddNewSubmission()
        {
            // Arrange:
            SubmissionSendViewModel viewModel = new SubmissionSendViewModel();

            // Act:
            var result = _subService.addNewSubmission(viewModel);

            // Assert:
            Assert.IsTrue(result);
        }
    }
}
