/*
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * API version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger
import (
	"time"
)

type FormatTest struct {
	Integer int32 `json:"integer,omitempty"`
	Int32_ int32 `json:"int32,omitempty"`
	Int64_ int64 `json:"int64,omitempty"`
	Number float64 `json:"number"`
	Float float32 `json:"float,omitempty"`
	Double float64 `json:"double,omitempty"`
	String_ string `json:"string,omitempty"`
	Byte_ string `json:"byte"`
	Binary string `json:"binary,omitempty"`
	Date string `json:"date"`
	DateTime time.Time `json:"dateTime,omitempty"`
	Uuid string `json:"uuid,omitempty"`
	Password string `json:"password"`
}
