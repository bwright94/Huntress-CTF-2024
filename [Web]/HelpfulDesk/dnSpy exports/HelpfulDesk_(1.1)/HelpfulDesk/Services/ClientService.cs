using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using HelpfulDesk.Models;

namespace HelpfulDesk.Services
{
	// Token: 0x02000015 RID: 21
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientService
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00003298 File Offset: 0x00001498
		public ClientService()
		{
			this._clients = new List<Client>
			{
				new Client
				{
					Id = "28bfb49f-eab5-4f9d-9a66-e54d81976747",
					Name = "HOST-WIN-DX130S2",
					Online = true,
					CompanyName = "Acme Corporation",
					LastCheckIn = DateTime.Now.AddMinutes(-30.0),
					Filesystem = new List<FileItem>
					{
						new FileItem
						{
							Name = "C:\\Users\\administrator",
							IsDirectory = true,
							Children = new List<FileItem>
							{
								new FileItem
								{
									Name = "Desktop",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "flag.txt",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "shortcut.lnk",
											IsDirectory = false
										}
									}
								},
								new FileItem
								{
									Name = "Documents",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "Project.docx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "Reports",
											IsDirectory = true,
											Children = new List<FileItem>
											{
												new FileItem
												{
													Name = "Report1.pdf",
													IsDirectory = false
												},
												new FileItem
												{
													Name = "Report2.pdf",
													IsDirectory = false
												}
											}
										}
									}
								},
								new FileItem
								{
									Name = "Downloads",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "installer.exe",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "sample.zip",
											IsDirectory = false
										}
									}
								}
							}
						}
					}
				},
				new Client
				{
					Id = "a4200a28-dcf7-44f9-a980-eaa491dba9b1",
					Name = "client-jeremy-laptop",
					Online = false,
					CompanyName = "Globex Corporation",
					LastCheckIn = DateTime.Now.AddDays(-1.0),
					Filesystem = new List<FileItem>
					{
						new FileItem
						{
							Name = "Desktop",
							IsDirectory = true
						},
						new FileItem
						{
							Name = "Downloads",
							IsDirectory = true
						}
					}
				},
				new Client
				{
					Id = "ef66cf2f-9e0f-4254-b165-fad18a7d62d9",
					Name = "MACAW-3-win",
					Online = true,
					CompanyName = "Initech",
					LastCheckIn = DateTime.Now.AddHours(-2.0),
					Filesystem = new List<FileItem>
					{
						new FileItem
						{
							Name = "C:\\Users\\johnHammond",
							IsDirectory = true,
							Children = new List<FileItem>
							{
								new FileItem
								{
									Name = "Desktop",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "todo-list.txt",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "family-photo.jpg",
											IsDirectory = false
										}
									}
								},
								new FileItem
								{
									Name = "Documents",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "recipe-book.docx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "travel-plans.xlsx",
											IsDirectory = false
										}
									}
								},
								new FileItem
								{
									Name = "Downloads",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "music.mp3",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "ebook.pdf",
											IsDirectory = false
										}
									}
								}
							}
						}
					}
				},
				new Client
				{
					Id = "c5f1c694-26a1-4fe2-9803-7e9dbc70ea80",
					Name = "pointofsale-win-front",
					Online = true,
					CompanyName = "Hooli",
					LastCheckIn = DateTime.Now.AddMinutes(-45.0),
					Filesystem = new List<FileItem>
					{
						new FileItem
						{
							Name = "C:\\Users\\administrator",
							IsDirectory = true,
							Children = new List<FileItem>
							{
								new FileItem
								{
									Name = "Desktop",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "presentation.pptx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "budget.xlsx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "family-photo.jpg",
											IsDirectory = false
										}
									}
								},
								new FileItem
								{
									Name = "Documents",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "resume.docx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "project-notes.txt",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "meeting-minutes.pdf",
											IsDirectory = false
										}
									}
								},
								new FileItem
								{
									Name = "Downloads",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "software-setup.exe",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "design-templates.zip",
											IsDirectory = false
										}
									}
								}
							}
						}
					}
				},
				new Client
				{
					Id = "9ea3880f-df01-4135-82cf-90894d1e11f1",
					Name = "WIN-DL09284A5",
					Online = true,
					CompanyName = "Vehement Capital Partners",
					LastCheckIn = DateTime.Now.AddDays(-3.0),
					Filesystem = new List<FileItem>
					{
						new FileItem
						{
							Name = "C:\\Users\\h.Hacks",
							IsDirectory = true,
							Children = new List<FileItem>
							{
								new FileItem
								{
									Name = "Desktop",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "notes.txt",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "presentation.pptx",
											IsDirectory = false
										}
									}
								},
								new FileItem
								{
									Name = "Documents",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "resume.docx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "budget.xlsx",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "Projects",
											IsDirectory = true,
											Children = new List<FileItem>
											{
												new FileItem
												{
													Name = "ProjectA",
													IsDirectory = true
												},
												new FileItem
												{
													Name = "ProjectB",
													IsDirectory = true
												}
											}
										}
									}
								},
								new FileItem
								{
									Name = "Downloads",
									IsDirectory = true,
									Children = new List<FileItem>
									{
										new FileItem
										{
											Name = "setup.exe",
											IsDirectory = false
										},
										new FileItem
										{
											Name = "document.pdf",
											IsDirectory = false
										}
									}
								}
							}
						}
					}
				}
			};
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003ACB File Offset: 0x00001CCB
		public List<Client> GetClients()
		{
			return this._clients;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public Client GetClientById(string clientId)
		{
			return this._clients.FirstOrDefault((Client c) => c.Id.Equals(clientId, StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x04000088 RID: 136
		private readonly List<Client> _clients;
	}
}
