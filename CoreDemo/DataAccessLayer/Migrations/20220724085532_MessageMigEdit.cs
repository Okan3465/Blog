using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class MessageMigEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_WriterID",
                table: "Message2");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_WriterID1",
                table: "Message2");

            migrationBuilder.DropIndex(
                name: "IX_Message2_WriterID",
                table: "Message2");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Message2");

            migrationBuilder.RenameColumn(
                name: "WriterID1",
                table: "Message2",
                newName: "ReceiverUserWriterID");

            migrationBuilder.RenameIndex(
                name: "IX_Message2_WriterID1",
                table: "Message2",
                newName: "IX_Message2_ReceiverUserWriterID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2_Sender",
                table: "Message2",
                column: "Sender");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2_Writers_ReceiverUserWriterID",
                table: "Message2",
                column: "ReceiverUserWriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2_Writers_Sender",
                table: "Message2",
                column: "Sender",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_ReceiverUserWriterID",
                table: "Message2");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_Sender",
                table: "Message2");

            migrationBuilder.DropIndex(
                name: "IX_Message2_Sender",
                table: "Message2");

            migrationBuilder.RenameColumn(
                name: "ReceiverUserWriterID",
                table: "Message2",
                newName: "WriterID1");

            migrationBuilder.RenameIndex(
                name: "IX_Message2_ReceiverUserWriterID",
                table: "Message2",
                newName: "IX_Message2_WriterID1");

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Message2",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message2_WriterID",
                table: "Message2",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2_Writers_WriterID",
                table: "Message2",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2_Writers_WriterID1",
                table: "Message2",
                column: "WriterID1",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
