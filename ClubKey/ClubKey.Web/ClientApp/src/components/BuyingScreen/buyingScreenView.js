import React, { Component } from "react";
import UserInformation from "./userInformation";
import PaymentMethods from "./paymentMethods";
import OrderReview from "./orderReview";
import "../../styles/style_payment.css";
import "../../styles/style.css";
import {
	addTicket,
	getCityByClubId,
	getEvent,
	getUserById,
	getClubByEventId
} from "./apiRequests";

class BuyingScreenView extends Component {
	state = {
		city: null,
		user: null,
		club: null,
		numberOfTickets: 1,
		event: null,
		loadingUser: true, 
		loadingEvent: true, 
		loadingClub: true,
		loadingCity: true 
	};

	componentDidMount() {
		localStorage.setItem("name", "iivanic12");
		const { id } = this.props.match.params;
		this.getUser();
		this.getEventClubAndCity(id);
	}

	getUser = () => {
		getUserById(localStorage.getItem("name")).then(user => {
			this.setState({user, loadingUser: false});
		});
	};

	getEventClubAndCity = id => {
		getEvent(id).then(event => {
			this.setState({ event, loadingEvent: false });
			this.getClubAndCity();
		});
	};

	getClubAndCity = () => {
		getClubByEventId(this.state.event.id).then(club => {
			this.setState({ club, loadingClub: false});
			this.getCity();
		});
	}
	getCity = () => {
		getCityByClubId(this.state.club.id).then(city => {
		this.setState({ city, loadingCity: false });
		});
	};

	handleBuying = () => {
		for (let i; i < this.state.numberOfTickets; i++) {
			addTicket(this.props.user.id, this.props.event.id, this.props.event.price);
		}
	};

	handleAddTicket = () => {
		let numberOfTickets = this.state.numberOfTickets + 1;
		this.setState({ numberOfTickets});
	}

	handleRemoveTicket = () => {
		if(this.state.numberOfTickets > 1){
			let numberOfTickets = this.state.numberOfTickets - 1;
			this.setState({ numberOfTickets});
		}
	}
	
	render() {
	const { user, loadingCity, loadingUser, loadingEvent, loadingClub,
			city, numberOfTickets, event, club } = this.state;
	return (
		<div>
		{
			loadingUser || user === undefined ? 
			<div>Loading User...</div>: 
			<UserInformation user={user} />
		}
		<PaymentMethods/>
		{
			loadingCity || loadingEvent || loadingClub ||
			city === undefined || event === undefined || club === undefined?
			<div>Loading Order Review...</div>: 
			<OrderReview
			event={event}
			club={club}
			city={city}
			numberOfTickets={numberOfTickets}
			addTicket={this.handleAddTicket}
			removeTicket={this.handleRemoveTicket}
			/>
		}
		<section className="discount-code">
			<h6 className="discount-code-title">Discount code:</h6>
			<input type="text" placeholder="Code..." className="input-field" />
		</section>
		<button
			onClick={this.handleBuying}
			className="purple-button full-width"
		>
			BUY NOW
		</button>
	</div>
);
}
}

export default BuyingScreenView;
