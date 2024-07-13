namespace PagesDemoTest
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.Maui.Controls;

    public class MockNavigation : INavigation
    {
        private Stack<Page> _navigationStack = new Stack<Page>();
        private Stack<Page> _modalStack = new Stack<Page>();

        public IReadOnlyList<Page> NavigationStack => _navigationStack.ToList();
        public IReadOnlyList<Page> ModalStack => _modalStack.ToList();

        public Task PushAsync(Page page)
        {
            _navigationStack.Push(page);
            return Task.CompletedTask;
        }

        public Task<Page> PopAsync()
        {
            if (_navigationStack.Count > 1)
            {
                return Task.FromResult(_navigationStack.Pop());
            }
            return Task.FromResult<Page>(null);
        }

        public Task PushModalAsync(Page page)
        {
            _modalStack.Push(page);
            return Task.CompletedTask;
        }

        public Task<Page> PopModalAsync()
        {
            if (_modalStack.Any())
            {
                return Task.FromResult(_modalStack.Pop());
            }
            return Task.FromResult<Page>(null);
        }
        
        public void RemovePage(Page page)
        {
            _navigationStack = new Stack<Page>(_navigationStack.Where(p => p != page));
        }

        public void InsertPageBefore(Page page, Page before)
        {
            var stack = new Stack<Page>(_navigationStack.Reverse());
            var newStack = new Stack<Page>();

            while (stack.Any())
            {
                var current = stack.Pop();
                if (current == before)
                {
                    newStack.Push(page);
                }
                newStack.Push(current);
            }

            _navigationStack = new Stack<Page>(newStack.Reverse());
        }

        public Task<Page> PopToRootAsync()
        {
            while (_navigationStack.Count > 1)
            {
                _navigationStack.Pop();
            }
            return Task.FromResult(_navigationStack.Peek());
        }

        public Task PushAsync(Page page, bool animated)
        {
            return PushAsync(page);
        }

        public Task<Page> PopAsync(bool animated)
        {
            return PopAsync();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            return PushModalAsync(page);
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            return PopModalAsync();
        }

        Task INavigation.PopToRootAsync()
        {
            while (_navigationStack.Count > 1)
            {
                _navigationStack.Pop();
            }
            return Task.FromResult(_navigationStack.Peek());
        }

        public Task PopToRootAsync(bool animated)
        {
           return PopToRootAsync();
        }
    }


}
