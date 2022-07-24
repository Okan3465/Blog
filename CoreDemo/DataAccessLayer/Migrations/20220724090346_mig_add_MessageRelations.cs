using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_MessageRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_ReceiverUserWriterID",
                table: "Message2");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_Sender",
                table: "Message2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message2",
                table: "Message2");

            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Message2");

            migrationBuilder.RenameTable(
                name: "Message2",
                newName: "Message2s");

            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Message2s",
                newName: "SenderID");

            migrationBuilder.RenameColumn(
                name: "ReceiverUserWriterID",
                table: "Message2s",
                newName: "ReceiverID");

            migrationBuilder.RenameIndex(
                name: "IX_Message2_Sender",
                table: "Message2s",
                newName: "IX_Message2s_SenderID");

            migrationBuilder.RenameIndex(
                name: "IX_Message2_ReceiverUserWriterID",
                table: "Message2s",
                newName: "IX_Message2s_ReceiverID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message2s",
                table: "Message2s",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_Writers_ReceiverID",
                table: "Message2s",
                column: "ReceiverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_Writers_SenderID",
                table: "Message2s",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_Writers_ReceiverID",
                table: "Message2s");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_Writers_SenderID",
                table: "Message2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message2s",
                table: "Message2s");

            migrationBuilder.RenameTable(
                name: "Message2s",
                newName: "Message2");

            migrationBuilder.RenameColumn(
                name: "SenderID",
                table: "Message2",
                newName: "Sender");

            migrationBuilder.RenameColumn(
                name: "ReceiverID",
                table: "Message2",
                newName: "ReceiverUserWriterID");

            migrationBuilder.RenameIndex(
                name: "IX_Message2s_SenderID",
                table: "Message2",
                newName: "IX_Message2_Sender");

            migrationBuilder.RenameIndex(
                name: "IX_Message2s_ReceiverID",
                table: "Message2",
                newName: "IX_Message2_ReceiverUserWriterID");

            migrationBuilder.AddColumn<int>(
                name: "Receiver",
                table: "Message2",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message2",
                table: "Message2",
                column: "MessageID");

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
    }
}
