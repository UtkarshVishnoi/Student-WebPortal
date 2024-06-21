function toggleSidebar() {
	console.log("hello");
	const sidebarElem = document.getElementById("sidebar-div");
	const detailElem = document.getElementById("detail-container");
	sidebarElem.classList.toggle("sidebar-open")

	if(sidebarElem.style.width === "var(--sidebar-width)") {
		sidebarElem.style.width = "5%";
		detailElem.style.width = "95%";
	}
	else {
		sidebarElem.style.width = "var(--sidebar-width)";
		detailElem.style.width = "calc(100% - var(--sidebar-width))";
	}
}