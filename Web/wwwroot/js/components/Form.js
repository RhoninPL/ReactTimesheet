import React from "react";
import Button from 'react-bootstrap/lib/Button';
import FormGroup from 'react-bootstrap/lib/FormGroup';
import FormControl from 'react-bootstrap/lib/FormControl';
import GridTimeSheet from './Grid/GridTimeSheet';
import './Form.scss';

class Form extends React.Component {
    constructor(props) {
        super(props);
        this.state = { hours: [], company: "", time: "" };
        this.addNewHour = this.addNewHour.bind(this);
        this.handleChangeCompany = this.handleChangeCompany.bind(this);
        this.handleChangeTime = this.handleChangeTime.bind(this);
    }

    handleChangeCompany(event) {
        this.setState({ company: event.target.value });
    }

    handleChangeTime(event) {
        this.setState({ time: event.target.value });
    }

    addNewHour(event) {
        event.preventDefault();
        if (this.state.time !== "" && this.state.company !== "") {
            var newHours = this.state.hours;
            newHours.push({ Name: "test", Time: this.state.time, Company: this.state.company });
            this.setState({ hours: newHours });
        }
    }

    componentDidMount() {
        this.setState({
            hours: [{
                Name: "Jan Kowalski",
                Time: "8",
                Company: "Microsoft"
            }, {
                Name: "Kazimierz Nowak",
                Time: "8",
                Company: "Google"
            }]
        });
    }

    render() {
        return (
            <div className="main-timesheet">
                <div className="timesheet-grid">
                    <GridTimeSheet hours={this.state.hours} />
                </div>
                <form>
                    <FormGroup className="form-group">
                        <FormControl type="text" id="company" placeholder="Enter company name" onChange={this.handleChangeCompany} value={this.state.company} />
                        <FormControl type="number" id="time" placeholder="Enter time" onChange={this.handleChangeTime} value={this.state.time} />
                        <Button type="submit" onClick={this.addNewHour.bind(this)}>Save</Button>
                    </FormGroup>
                </form>
            </div>
        );
    }
};

export default Form;