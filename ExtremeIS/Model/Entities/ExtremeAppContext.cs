namespace ExtremeIS.Model.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExtremeAppContext : DbContext
    {
        public ExtremeAppContext()
            : base("name=ExtremeAppContext")
        {
        }

        public virtual DbSet<attendance> attendances { get; set; }
        public virtual DbSet<daily_ticket> daily_ticket { get; set; }
        public virtual DbSet<daily_ticket_type> daily_ticket_type { get; set; }
        public virtual DbSet<education_level> education_level { get; set; }
        public virtual DbSet<gear> gears { get; set; }
        public virtual DbSet<gear_borrowing> gear_borrowing { get; set; }
        public virtual DbSet<gear_borrowing_items> gear_borrowing_items { get; set; }
        public virtual DbSet<gear_category> gear_category { get; set; }
        public virtual DbSet<gear_size> gear_size { get; set; }
        public virtual DbSet<gear_size_items> gear_size_items { get; set; }
        public virtual DbSet<gear_write_off> gear_write_off { get; set; }
        public virtual DbSet<manufacturer> manufacturers { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<member_education> member_education { get; set; }
        public virtual DbSet<membership_card> membership_card { get; set; }
        public virtual DbSet<membership_type> membership_type { get; set; }
        public virtual DbSet<membeship_fee_payment> membeship_fee_payment { get; set; }
        public virtual DbSet<user_account> user_account { get; set; }
        public virtual DbSet<user_log> user_log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<daily_ticket>()
                .Property(e => e.person_name)
                .IsUnicode(false);

            modelBuilder.Entity<daily_ticket_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<education_level>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<gear>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<gear>()
                .Property(e => e.descritption)
                .IsUnicode(false);

            modelBuilder.Entity<gear_borrowing_items>()
                .Property(e => e.quantity)
                .IsUnicode(false);

            modelBuilder.Entity<gear_category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<gear_size>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<gear_size_items>()
                .HasMany(e => e.gear_borrowing_items)
                .WithRequired(e => e.gear_size_items)
                .HasForeignKey(e => new { e.gear_id, e.gear_size_id });

            modelBuilder.Entity<gear_size_items>()
                .HasMany(e => e.gear_write_off)
                .WithRequired(e => e.gear_size_items)
                .HasForeignKey(e => new { e.gear_id, e.gear_size_id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manufacturer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<manufacturer>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.profile_picture)
                .IsUnicode(false);

            modelBuilder.Entity<member_education>()
                .Property(e => e.commission_member_1)
                .IsUnicode(false);

            modelBuilder.Entity<member_education>()
                .Property(e => e.commission_member_2)
                .IsUnicode(false);

            modelBuilder.Entity<member_education>()
                .Property(e => e.commission_member_3)
                .IsUnicode(false);

            modelBuilder.Entity<membership_card>()
                .Property(e => e.barcode_number)
                .IsUnicode(false);

            modelBuilder.Entity<membership_card>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<membership_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .Property(e => e.privilegies)
                .IsUnicode(false);

            modelBuilder.Entity<user_account>()
                .HasMany(e => e.daily_ticket)
                .WithRequired(e => e.user_account)
                .HasForeignKey(e => e.issuer_user_account_id);

            modelBuilder.Entity<user_account>()
                .HasMany(e => e.gear_borrowing)
                .WithRequired(e => e.user_account)
                .HasForeignKey(e => e.issuer_user_account_id);

            modelBuilder.Entity<user_account>()
                .HasMany(e => e.gear_borrowing1)
                .WithOptional(e => e.user_account1)
                .HasForeignKey(e => e.receiver_user_account_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<user_account>()
                .HasMany(e => e.gear_write_off)
                .WithRequired(e => e.user_account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_account>()
                .HasMany(e => e.membership_card)
                .WithRequired(e => e.user_account)
                .HasForeignKey(e => e.issuer_user_account_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_account>()
                .HasMany(e => e.membeship_fee_payment)
                .WithRequired(e => e.user_account)
                .HasForeignKey(e => e.issuer_user_account_id);

            modelBuilder.Entity<user_log>()
                .Property(e => e._event)
                .IsUnicode(false);

            modelBuilder.Entity<user_log>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
