function toggleSidebar() {
	const sidebarElem = document.getElementById("sidebar-div");
	const detailElem = document.getElementById("detail-container");
	const searchElem = document.getElementById("search-div");
	const navIconElem = document.getElementById("nav-icon");
	sidebarElem.classList.toggle("sidebar-open")

	if(sidebarElem.style.width === "var(--sidebar-width)") {
		sidebarElem.style.width = "2%";
		detailElem.style.width = "98%";
		searchElem.style.display = "none";
		navIconElem.setAttribute("src", "images/right.svg");
	}
	else {
		searchElem.style.display = "flex";
		sidebarElem.style.width = "var(--sidebar-width)";
		detailElem.style.width = "calc(100% - var(--sidebar-width))";
		navIconElem.setAttribute("src", "images/left.svg");
	}
}