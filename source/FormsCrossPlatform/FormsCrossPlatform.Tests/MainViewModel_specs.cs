using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormsCrossPlatform.Tests
{
    [TestClass]
    public class MainViewModel_specs
    {
        [TestMethod]
        public void when_user_is_added_via_add_button_then_name_entry_should_be_cleared()
        {
            // Arrange
            var sut = new MainViewModel // SUT는 'System Under Test'를 뜻합니다. https://en.wikipedia.org/wiki/System_under_test
            {
                Name = "foo",
                Email = "foo@test.com"
            };

            // Act
            sut.AddCommand.Execute(null);

            // Assert
            Assert.IsTrue(string.IsNullOrEmpty(sut.Name), "Name 속성이 초기화되지 않았습니다.");
        }

        [TestMethod]
        public void when_user_is_added_via_add_button_then_PropertyChanged_event_should_be_raised_with_Name_property()
        {
            // Arrange
            var sut = new MainViewModel
            {
                Name = "foo",
                Email = "foo@test.com"
            };
            bool raised = false;
            sut.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Name")
                    raised = true;
            };

            // Act
            sut.AddCommand.Execute(null);

            // Assert
            Assert.IsTrue(raised, "Name 속성에 대해 PropertyChanged 이벤트가 발생하지 않았습니다.");
        }

        [TestMethod]
        public void when_user_is_added_via_add_button_then_email_entry_should_be_cleared()
        {
            // Arrange
            var sut = new MainViewModel
            {
                Name = "foo",
                Email = "foo@test.com"
            };

            // Act
            sut.AddCommand.Execute(null);

            // Assert
            Assert.IsTrue(string.IsNullOrEmpty(sut.Email), "Email 속성이 초기화되지 않았습니다.");
        }

        [TestMethod]
        public void when_user_is_added_via_add_button_then_PropertyChanged_event_should_be_raised_with_Email_property()
        {
            // Arrange
            var sut = new MainViewModel
            {
                Name = "foo",
                Email = "foo@test.com"
            };
            bool raised = false;
            sut.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Email")
                    raised = true;
            };

            // Act
            sut.AddCommand.Execute(null);

            // Assert
            Assert.IsTrue(raised, "Email 속성에 대해 PropertyChanged 이벤트가 발생하지 않았습니다.");
        }
    }
}
