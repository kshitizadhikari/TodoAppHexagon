using TodoAppHexagon.Core.Entities;
using TodoAppHexagon.Core.Ports;

namespace TodoAppHexagon.Adapters.SqlServer.Test
{
    [TestClass]
    public class SqlServerTodoRepositoryTests
    {
        private readonly SqlServerTodoRepository _repository;

        public SqlServerTodoRepositoryTests(SqlServerTodoRepository repository)
        {
            _repository = repository;
        }

        [TestMethod]
        public async Task GetAllAsync_ReturnsListOfTodoItems()
        {
            string t1 = "Task1";
            string t2 = "Task2";
            string is1 = "Pending";
            string is2 = "Completed";

            TodoItem item1 = new TodoItem(Guid.NewGuid(), t1, is1)
            {
                Title = t1,
                IsCompleted = is1
            };
            TodoItem item2 = new TodoItem(Guid.NewGuid(), t2, is2)
            {
                Title = t2,
                IsCompleted = is2
            };

            await _repository.CreateAsync(item1);
            await _repository.CreateAsync(item2);

            var result = await _repository.GetAllAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Any(item => item.Title == "Task1"));
            Assert.IsTrue(result.Any(item => item.Title == "Task2"));
        }
    }
}