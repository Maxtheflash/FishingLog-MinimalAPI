using FishingLogMinimalApi.Models;

namespace FishingLogMinimalApi.Data
{
    public static class CatchRepository
    {
        private static readonly List<CatchRecord> _catches = new()
        {
            new CatchRecord
            {
                Id = 1,
                Species = "Largemouth Bass",
                LengthInInches = 15.5,
                WeightInPounds = 2.3,
                Location = "Local Pond",
                DateCaught = new DateTime(2025, 5, 1)
            },
            new CatchRecord
            {
                Id = 2,
                Species = "Smallmouth Bass",
                LengthInInches = 17.2,
                WeightInPounds = 2.8,
                Location = "River",
                DateCaught = new DateTime(2025, 6, 3)
            }
        };

        public static IEnumerable<CatchRecord> GetAll() => _catches;

        public static CatchRecord? GetById(int id) =>
            _catches.FirstOrDefault(c => c.Id == id);

        public static CatchRecord Add(CatchRecord record)
        {
            int newId = _catches.Any() ? _catches.Max(c => c.Id) + 1 : 1;
            record.Id = newId;
            _catches.Add(record);
            return record;
        }

        public static bool Update(int id, CatchRecord updated)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Species = updated.Species;
            existing.LengthInInches = updated.LengthInInches;
            existing.WeightInPounds = updated.WeightInPounds;
            existing.Location = updated.Location;
            existing.DateCaught = updated.DateCaught;

            return true;
        }

        public static bool Delete(int id)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            _catches.Remove(existing);
            return true;
        }
    }
}
