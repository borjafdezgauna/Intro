namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void Find()
        {
            int[] array = new int[] { 3, 0, 5, 1, -3, 1, 2 };

            Assert.Equal(2, IntroExercises.Exercises.Find(array, 5));
            Assert.Equal(4, IntroExercises.Exercises.Find(array, -3));
            Assert.Equal(3, IntroExercises.Exercises.Find(array, 1));
            Assert.Equal(-1, IntroExercises.Exercises.Find(array, 14)); //Should return -1 if the value is not found
            Assert.Equal(-1, IntroExercises.Exercises.Find(null, 1)); //Should return -1 if no array is given
        }

        [Fact]
        public void Count()
        {
            int[] array = new int[] { 3, 0, 5, 1, -3, 1, 2 };

            Assert.Equal(1, IntroExercises.Exercises.Count(array, 5));
            Assert.Equal(1, IntroExercises.Exercises.Count(array, -3));
            Assert.Equal(2, IntroExercises.Exercises.Count(array, 1));
            Assert.Equal(0, IntroExercises.Exercises.Count(array, 14)); //Should return 0 if the value is not found
            Assert.Equal(0, IntroExercises.Exercises.Count(null, 1)); //Should return -1 if no array is given
        }

        [Fact]
        public void FindWithRange()
        {
            int[] array = new int[] { 3, 0, 5, 1, -3, 1, 2 };

            Assert.Equal(2, IntroExercises.Exercises.Find(array, 5, 0, array.Length - 1));
            Assert.Equal(2, IntroExercises.Exercises.Find(array, 5, 2, array.Length - 1));
            Assert.Equal(-1, IntroExercises.Exercises.Find(array, 5, 4, array.Length - 1));
            Assert.Equal(-1, IntroExercises.Exercises.Find(array, 5, array.Length - 1, 4)); 
            Assert.Equal(3, IntroExercises.Exercises.Find(array, 1, 0, array.Length - 1));
            Assert.Equal(5, IntroExercises.Exercises.Find(array, 1, 4, array.Length - 1));
            Assert.Equal(5, IntroExercises.Exercises.Find(array, 1, 4, 6));
            Assert.Equal(-1, IntroExercises.Exercises.Find(array, 1, 6, 4));  //Should return -1 if the range is invalid (end < start)
            Assert.Equal(-1, IntroExercises.Exercises.Find(array, 14)); //Should return -1 if the value is not found
            Assert.Equal(-1, IntroExercises.Exercises.Find(null, 1)); //Should return -1 if no array is given
        }

        [Fact]
        public void CountWithRange()
        {
            int[] array = new int[] { 3, 0, 5, 1, -3, 1, 2 };

            Assert.Equal(1, IntroExercises.Exercises.Count(array, 5, 0, array.Length - 1));
            Assert.Equal(1, IntroExercises.Exercises.Count(array, 5, 2, array.Length - 1));
            Assert.Equal(0, IntroExercises.Exercises.Count(array, 5, 4, array.Length - 1));
            Assert.Equal(0, IntroExercises.Exercises.Count(array, 5, array.Length - 1, 4)); //Should return 0 if the range is invalid (end < start)
            Assert.Equal(2, IntroExercises.Exercises.Count(array, 1, 0, array.Length - 1));
            Assert.Equal(1, IntroExercises.Exercises.Count(array, 1, 4, array.Length - 1));
            Assert.Equal(0, IntroExercises.Exercises.Count(array, 1, 4, 2)); //Should return 0 if the range is invalid (end < start)
            Assert.Equal(0, IntroExercises.Exercises.Count(array, 14)); //Should return 0 if the value is not found
            Assert.Equal(0, IntroExercises.Exercises.Count(null, 1)); //Should return 0 if no array is given
        }

        [Fact]
        public void AreEqual()
        {
            Assert.True(IntroExercises.Exercises.AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 1, 2 }));
            Assert.True(IntroExercises.Exercises.AreEqual(new int[] { 1, 1, 2 }, new int[] { 1, 2, 1 }));
            Assert.False(IntroExercises.Exercises.AreEqual(new int[] { 1, 1, 2 }, new int[] { 2, 1, 2 }));
            Assert.False(IntroExercises.Exercises.AreEqual(new int[] { 1, 2, 2 }, new int[] { 2, 1, 2, 3 }));
            Assert.False(IntroExercises.Exercises.AreEqual(new int[] { 1, 1, 2 }, new int[] { 1, 2 }));
            Assert.False(IntroExercises.Exercises.AreEqual(new int[] { 1, 2 }, new int[] { 1, 1, 2 }));
            Assert.False(IntroExercises.Exercises.AreEqual(new int[] { 1, 1, 2 }, null));
            Assert.False(IntroExercises.Exercises.AreEqual(new int[] { 1, 1, 2 }, new int[] { }));
        }
    }
}