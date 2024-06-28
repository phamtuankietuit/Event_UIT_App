import React from "react"
import { Text, TouchableOpacity, View, Image } from "react-native"
import { format } from "date-fns"
import logo from "../../../assets/images/anhtruong.jpg"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faEye, faEyeSlash } from "@fortawesome/free-solid-svg-icons"
import { useRouter, Link } from "expo-router"

function Event_Item({ item, deleteItem, deleteButton }) {
  const router = useRouter()

  // console.log(item.id)

  return (
    <Link
      href={{
        pathname: "(page)/post-detail/[id]",
        params: {
          id: item.id,
        },
      }}
    >
      <View
        className='mx-2 my-[5px] h-[90px] flex-row  items-center rounded-lg bg-white p-1'
        style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}
      >
        <View className='text-wrap flex h-[100%] w-[25%] items-center justify-center'>
          <Image
            source={item?.images ? { uri: item?.images[0].imageUrl } : logo}
            className='me-4 h-[85%] w-[85%] rounded-[3px] bg-white'
          />
        </View>
        <View className='mx-3 flex-1'>
          <Text numberOfLines={2} className='mb-3 font-semibold'>
            {item.title}
          </Text>
          {item.isPublished === true ? (
            <Text className='text-xs'>
              Ngày công bố : {format(item?.publishedDate, "HH:mm - dd/MM/yyyy")}
            </Text>
          ) : (
            <Text className='text-xs'>
              Thời gian bắt đầu :{" "}
              {format(item?.startDate, "HH:mm - dd/MM/yyyy")}
            </Text>
          )}
        </View>
        {deleteButton && (
          <TouchableOpacity className='mr-2 flex items-center justify-center'>
            <View className='rounded-full bg-orange-400 p-3'>
              <FontAwesomeIcon
                icon={item.isPublished === true ? faEye : faEyeSlash}
                color='white'
              />
            </View>
          </TouchableOpacity>
        )}
      </View>
    </Link>
  )
}

export default Event_Item
