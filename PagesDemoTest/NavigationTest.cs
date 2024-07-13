namespace PagesDemoTest
{
    [TestFixture]
    public class NavigationTests
    {
        private MockNavigation _mockNavigation;
        private Page _mainPage;
        private Page _page1;
        private Page _page2;


        [SetUp]
        public void Setup()
        {
            _mockNavigation = new MockNavigation();
            _mainPage = new ContentPage { Title = "MainPage" };
            _page1 = new ContentPage { Title = "Page1" };
            _page2 = new ContentPage { Title = "Page2" };
            _mockNavigation.PushAsync(_mainPage);
        }

        [Test]
        public async Task PushAsync_AddsPageToStack()
        {
            await _mockNavigation.PushAsync(_page1);
            Assert.That(2, Is.EqualTo(_mockNavigation.NavigationStack.Count));
            Assert.That(_page1,Is.EqualTo(_mockNavigation.NavigationStack.Last()));
        }

        [Test]
        public async Task PopAsync_RemovesPageFromStack()
        {
            await _mockNavigation.PushAsync(_page1);
            await _mockNavigation.PopAsync();
            Assert.That(1, Is.EqualTo(_mockNavigation.NavigationStack.Count));
            Assert.That(_mainPage, Is.EqualTo(_mockNavigation.NavigationStack.Last()));
        }

        [Test]
        public async Task PushModalAsync_AddsPageToModalStack()
        {
            await _mockNavigation.PushModalAsync(_page1);
            Assert.That(1, Is.EqualTo(_mockNavigation.ModalStack.Count));
            Assert.That(_page1, Is.EqualTo(_mockNavigation.ModalStack.Last()));
        }

        [Test]
        public async Task PopModalAsync_RemovesPageFromModalStack()
        {
            await _mockNavigation.PushModalAsync(_page1);
            await _mockNavigation.PopModalAsync();
            Assert.That(0, Is.EqualTo(_mockNavigation.ModalStack.Count));
        }

        [Test]
        public void RemovePage_RemovesSpecificPage()
        {
            _mockNavigation.PushAsync(_page1);
            _mockNavigation.PushAsync(_page2);
            _mockNavigation.RemovePage(_page1);
            Assert.That(2, Is.EqualTo(_mockNavigation.NavigationStack.Count));
            Assert.IsFalse(_mockNavigation.NavigationStack.Contains(_page1));
        }

        [Test]
        public void InsertPageBefore_InsertsPageCorrectly()
        {
            _mockNavigation.PushAsync(_page1);
            _mockNavigation.InsertPageBefore(_page2, _page1);
            Assert.That(3, Is.EqualTo(_mockNavigation.NavigationStack.Count));
            Assert.That(_page2, Is.EqualTo(_mockNavigation.NavigationStack.ElementAt(1)));
        }

    }
}